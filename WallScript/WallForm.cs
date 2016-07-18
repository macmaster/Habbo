using System;
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
using System.IO;
using System.Text.RegularExpressions;

namespace WallScript {
	public partial class WallForm: ExtensionForm {

		// move packet headers
		public int packet_count = 3;
		public string header_file = "../headers/wallscript_packets.txt";
		protected ushort SAY_OUT = 0;
		protected ushort MOVE_WINDOW = 0;
		protected ushort CLICK_WINDOW = 0;

		// window data
		protected int windowID = 0;
		protected string windowFace = "r";

		public WallForm() {
			// read from packet file
			if(File.Exists(header_file)) {
				// read in packet headers.
				string[] headers = new string[packet_count];
				string[] wall_packets = File.ReadAllLines(header_file);
				for(int idx = 0; idx < packet_count; idx++) {
					string[] matches = Regex.Matches(wall_packets[idx], "[0-9]+").Cast<Match>().Select(m => m.Value).ToArray();
					headers[idx] = matches.Length > 0 ? matches[0] : "0";
				}

				// set the packet headers
				ushort.TryParse(headers[0], out SAY_OUT);
				ushort.TryParse(headers[1], out MOVE_WINDOW);
				ushort.TryParse(headers[2], out CLICK_WINDOW);
			}
			else {
				// build packet buffer
				string[] wall_packets = new String[packet_count];
				wall_packets[0] = "SAY_OUT:          0";
				wall_packets[1] = "MOVE_WINDOW:      0";
				wall_packets[2] = "CLICK_WINDOW:     0";

				// commit to file
				File.WriteAllLines(header_file, wall_packets);
			}

			// attach triggers
			Triggers.OutAttach(CLICK_WINDOW, OnWindowClicked);
			InitializeComponent();
		}

		// Intercept the window ID on double click
		protected void OnWindowClicked(InterceptedEventArgs obj) {

			// byteify the packet
			HMessage hmsg = obj.Packet;
			byte[] data = hmsg.ToBytes();

			// parse-set the windowID 
			windowID = 0;
			windowID += (data[9] << 0);
			windowID += (data[8] << 8);
			windowID += (data[7] << 16);
			windowID += (data[6] << 24);

			//Connection.SendToServerAsync(SAY_OUT, (windowID / 10000).ToString(), 0, 0);
		}

		private void faceLeft_Click(object sender, EventArgs e) {
			windowFace = "l";
		}

		private void faceRight_Click(object sender, EventArgs e) {
			windowFace = "r";
		}

		private void moveWindow_Click(object sender, EventArgs e) {
			// window params
			int w_x = (int)widthX.Value;
			int w_y = (int)widthY.Value;
			int l_x = (int)lengthX.Value;
			int l_y = (int)lengthY.Value;

			// build move string
			string move_string = ":w=" + w_x + "," + w_y + " ";
			move_string += "l=" + l_x + "," + l_y + " " + windowFace;

			// packet length
			int length = 2 + 4 + 2 + 4 + move_string.Length;
			byte[] packet = new byte[length];

			// packet length and header
			packet[0] = packet[1] = packet[2] = 0;
			packet[3] = (byte)(length - 4);
			packet[4] = (byte)(MOVE_WINDOW >> 8);
			packet[5] = (byte)(MOVE_WINDOW & 0xFF);

			// encode window ID
			packet[6] = (byte)((windowID >> 24) & 0xFF);
			packet[7] = (byte)((windowID >> 16) & 0xFF);
			packet[8] = (byte)((windowID >> 8) & 0xFF);
			packet[9] = (byte)((windowID >> 0) & 0xFF);

			// build string length encode string
			int pdx = 12, idx = 0;
			packet[10] = 0;
			packet[11] = (byte)(move_string.Length & 0xFF);
			while(pdx < length) {
				packet[pdx++] = (byte)move_string[idx++];
			}

			// debug print packet
			foreach(Byte b in packet) {
				Console.Write(b.ToString() + " ");
			}
			Console.Write("\n" + windowID + "\n");

			// test packet send by byte arr
			Connection.SendToServerAsync(packet);
		}

		private void PacketSubmit_Click(object sender, EventArgs e) {
			// detach packet headers
			Triggers.OutDetach(CLICK_WINDOW); // window

			// set packet headers
			ushort.TryParse(SayOUT.Text, out SAY_OUT);
			ushort.TryParse(WindowMOVE.Text, out MOVE_WINDOW);
			ushort.TryParse(WindowCLICK.Text, out CLICK_WINDOW);

			// build packet buffer
			string[] wall_packets = new String[packet_count];
			wall_packets[0] = "SAY_OUT:          " + SAY_OUT;
			wall_packets[1] = "MOVE_WINDOW:      " + MOVE_WINDOW;
			wall_packets[2] = "CLICK_WINDOW:     " + CLICK_WINDOW;

			// commit to file
			File.WriteAllLines(header_file, wall_packets); ;

			// attach packet header
			Triggers.OutAttach(CLICK_WINDOW, OnWindowClicked); //window packet

		}

		private void settings_Load(object sender, EventArgs e) {
			// init settings menu.
			SayOUT.Text = SAY_OUT.ToString();
			WindowMOVE.Text = MOVE_WINDOW.ToString();
			WindowCLICK.Text = CLICK_WINDOW.ToString();
		}

	}
}
