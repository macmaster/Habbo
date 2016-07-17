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
using System.Text.RegularExpressions;

namespace Mimic {
	public partial class MimicForm: ExtensionForm {
		// chat packet headers'
		public int packet_count = 5;
		public ushort SAY_IN = 0;
		public ushort SAY_OUT = 0;
		public ushort SHOUT_IN = 0;
		public ushort SHOUT_OUT = 0;

		// trade headers
		public ushort TRADE_START = 0;

		// init copy
		private int copyID = 0;
		private bool mimicFlag = false;
		private bool tradeFlag = false;

		public MimicForm() {
			// read from packet file
			if(File.Exists("../headers/mimic_packets.txt")) {
				// read in packet headers.
				string[] headers = new string[packet_count];
				string[] mimic_packets = File.ReadAllLines("../headers/mimic_packets.txt");
				for(int idx = 0; idx < packet_count; idx++) {
					string[] matches = Regex.Matches(mimic_packets[idx], "[0-9]+").Cast<Match>().Select(m => m.Value).ToArray();
					headers[idx] = matches.Length > 0 ? matches[0] : "0";
				}

				// set the packet headers
				ushort.TryParse(headers[0], out SAY_IN);
				ushort.TryParse(headers[1], out SAY_OUT);
				ushort.TryParse(headers[2], out SHOUT_IN);
				ushort.TryParse(headers[3], out SHOUT_OUT);
				ushort.TryParse(headers[4], out TRADE_START);
			}
			else {
				// build packet buffer
				string[] mimic_packets = new String[packet_count];
				mimic_packets[0] = "SAY_IN:     0";
				mimic_packets[1] = "SAY_OUT:    0";
				mimic_packets[2] = "SHOUT_IN:   0";
				mimic_packets[3] = "SHOUT_OUT:  0";
				mimic_packets[4] = "TRADE:      0";

				// commit to file
				File.WriteAllLines("../headers/mimic_packets.txt", mimic_packets);
			}

			// set triggers
			Triggers.InAttach(SHOUT_IN, OnShoutIncoming);
			Triggers.InAttach(SAY_IN, OnChatIncoming);
			Triggers.OutAttach(TRADE_START, OnPlayerTraded);
			InitializeComponent();
		}

		// flip the habbo chat string
		protected void OnChatIncoming(InterceptedEventArgs obj) {

			if(mimicFlag) {
				// byteify the packet
				HMessage hmsg = obj.Packet;
				byte[] data = hmsg.ToBytes();

				// parse msg length and sender key
				int sender = data[9] + (data[8] << 8) + (data[7] << 16) + (data[6] << 24);
				int len = data[11];

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
				int sender = data[9] + (data[8] << 8) + (data[7] << 16) + (data[6] << 24);
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

		// player traded
		protected void OnPlayerTraded(InterceptedEventArgs obj) {
			if(tradeFlag) {
				// byteify the packet
				obj.IsBlocked = true;
				HMessage tradepk = obj.Packet;
				byte[] data = tradepk.ToBytes();

				// set habbo trade id (chat id)
				int tradeID = data[9] + (data[8] << 8) + (data[7] << 16) + (data[6] << 24);
				IDBox.Value = tradeID;
				tradeFlag = false;
			}
		}

		private void start_Click(object sender, EventArgs e) {
			// clear text box and begin mimic
			copyID = (int)IDBox.Value;
			mimicFlag = true;
		}

		private void stop_Click(object sender, EventArgs e) {
			mimicFlag = false;
		}

		private void Trade_Click(object sender, EventArgs e) {
			tradeFlag = true;
		}

		private void PacketSubmit_Click(object sender, EventArgs e) {
			// detach packet headers
			Triggers.InDetach(SAY_IN);
			Triggers.InDetach(SHOUT_IN);
			Triggers.OutDetach(TRADE_START);

			// set packet headers
			ushort.TryParse(SayIN.Text, out SAY_IN);
			ushort.TryParse(SayOUT.Text, out SAY_OUT);
			ushort.TryParse(ShoutIN.Text, out SHOUT_IN);
			ushort.TryParse(ShoutOUT.Text, out SHOUT_OUT);
			ushort.TryParse(TradeStart.Text, out TRADE_START);

			// build packet buffer
			string[] mimic_packets = new String[packet_count];
			mimic_packets[0] = "SAY_IN:     " + SAY_IN;
			mimic_packets[1] = "SAY_OUT:    " + SAY_OUT;
			mimic_packets[2] = "SHOUT_IN:   " + SHOUT_IN;
			mimic_packets[3] = "SHOUT_OUT:  " + SHOUT_OUT;
			mimic_packets[4] = "TRADE:      " + TRADE_START;

			// commit to file
			File.WriteAllLines("../headers/mimic_packets.txt", mimic_packets);


			// attach packet header
			Triggers.InAttach(SAY_IN, OnChatIncoming);
			Triggers.InAttach(SHOUT_IN, OnShoutIncoming);
			Triggers.OutAttach(TRADE_START, OnPlayerTraded);

		}

		private void settings_Load(object sender, EventArgs e) {
			// init settings menu.
			SayIN.Text = SAY_IN.ToString();
			SayOUT.Text = SAY_OUT.ToString();
			ShoutIN.Text = SHOUT_IN.ToString();
			ShoutOUT.Text = SHOUT_OUT.ToString();
			TradeStart.Text = TRADE_START.ToString();
		}
	}
}
