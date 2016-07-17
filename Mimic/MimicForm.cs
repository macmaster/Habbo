using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Sulakore.Extensions;
using Sulakore.Communication;
using Sulakore.Protocol;

namespace Mimic {
	public partial class MimicForm: ExtensionForm {
		// chat packet headers
		public ushort SAY_IN = 0;
		public ushort SAY_OUT = 0;
		public ushort SHOUT_IN = 0;
		public ushort SHOUT_OUT = 0;

		// trade headers
		public ushort TRADE_START = 0;

		// init copy
		private int copyID = 0;
		private bool mimicFlag = false;

		public MimicForm() {
			// read from packet file
			if(File.Exists("mimic_packets.txt")) {
				string[] mimic_packets = File.ReadAllLines("mimic_packets.txt");
				foreach(String packet in mimic_packets) {
					Console.WriteLine(packet);
				}
			}
			else {
				File.Create("mimic_packets.txt");
				string[] mimic_packets = new String[5];
				mimic_packets[0] = "SAY_IN:\t 0";
				mimic_packets[1] = "SAY_OUT:\t 0";
				mimic_packets[2] = "SHOUT_IN:\t 0";
				mimic_packets[3] = "SHOUT_OUT:\t 0";
				mimic_packets[4] = "TRADE:\t 0";
			}

			// set triggers
			Triggers.InAttach(SHOUT_IN, OnShoutIncoming);
			Triggers.InAttach(SAY_IN, OnChatIncoming);
			InitializeComponent();
		}

		// flip the habbo chat string
		protected void OnChatIncoming(InterceptedEventArgs obj) {

			if(mimicFlag) {
				// byteify the packet
				HMessage hmsg = obj.Packet;
				byte[] data = hmsg.ToBytes();

				// parse msg length and sender key
				int sender = data[9] + (data[8] << 8);
				int len = data[11];
				//Connection.SendToServerAsync(SAY_OUT, "inside chat incoming , " + sender + "   " + copyID, 0, 0);

				if(sender == copyID) {
					// parse msg string
					List<byte> strlist = data.ToList();
					strlist = strlist.GetRange(12, len + 12);
					string char_string = Encoding.UTF8.GetString(strlist.ToArray());

					// print msg string
					Connection.SendToServerAsync(SAY_OUT, char_string, 0, 0);
				}
			}
		}


		// shout incoming
		protected void OnShoutIncoming(InterceptedEventArgs obj) {

			if(mimicFlag) {
				// byteify the packet
				HMessage hmsg = obj.Packet;
				byte[] data = hmsg.ToBytes();

				// parse msg length and sender key
				int sender = data[9] + (data[8] << 8);
				int len = data[11];

				if(sender == copyID) {
					// parse msg string
					List<byte> strlist = data.ToList();
					strlist = strlist.GetRange(12, len + 12);
					string char_string = Encoding.UTF8.GetString(strlist.ToArray());

					// print msg string
					Connection.SendToServerAsync(SHOUT_OUT, char_string, 0);
				}
			}
		}

		private void start_Click(object sender, EventArgs e) {
			// clear text box and begin mimic
			copyID = (int)IDBox.Value;
			mimicFlag = true;
			Connection.SendToServerAsync(SAY_OUT, "mimic after button: " + mimicFlag.ToString(), 0, 0);
		}

		private void stop_Click(object sender, EventArgs e) {
			mimicFlag = false;
		}

		private void Trade_Click(object sender, EventArgs e) {
			//TODO impl trade click
		}

		private void PacketSubmit_Click(object sender, EventArgs e) {
			// detach packet headers
			Triggers.InDetach(SAY_IN);
			Triggers.InDetach(SHOUT_IN);

			// set packet headers
			SAY_IN = (ushort)SayIN.Value;
			SAY_OUT = (ushort)SayOUT.Value;
			SHOUT_IN = (ushort)ShoutIN.Value;
			SHOUT_OUT = (ushort)ShoutOUT.Value;
			TRADE_START = (ushort)TradeStart.Value;

			// attach packet headers
			Triggers.InAttach(SAY_IN, OnChatIncoming);
			Triggers.InAttach(SHOUT_IN, OnShoutIncoming);
			Connection.SendToServerAsync(SAY_OUT, SAY_OUT.ToString(), 0, 0);

		}

	}
}
