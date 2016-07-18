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
using Sulakore.Protocol;
using Sulakore.Communication;
using System.IO;
using System.Text.RegularExpressions;

namespace FFBot {
	public partial class BotForm: ExtensionForm {
		// packet headers
		public int packet_count = 3;
		public string header_file = "../headers/ffbot_packets.txt";
		protected ushort SPACE_SEL = 0;
		protected ushort FURNI_MOVE = 0;
		protected ushort FURNI_PUT = 0;

		// ffbot flags
		private int delay = 0;
		private bool runFlag = false;
		private bool chooseFlag = false;

		private Tuple<int, int> space = new Tuple<int, int>(0, 0);

		public BotForm() {
			// read from packet file
			if(File.Exists(header_file)) {
				// read in packet headers.
				string[] headers = new string[packet_count];
				string[] ffbot_packets = File.ReadAllLines(header_file);
				for(int idx = 0; idx < packet_count; idx++) {
					string[] matches = Regex.Matches(ffbot_packets[idx], "[0-9]+").Cast<Match>().Select(m => m.Value).ToArray();
					headers[idx] = matches.Length > 0 ? matches[0] : "0";
				}

				// set the packet headers
				ushort.TryParse(headers[0], out SPACE_SEL);
				ushort.TryParse(headers[1], out FURNI_MOVE);
				ushort.TryParse(headers[2], out FURNI_PUT);
			}
			else {
				// build packet buffer
				string[] ffbot_packets = new String[packet_count];
				ffbot_packets[0] = "SPACE_SEL:     0";
				ffbot_packets[1] = "FURNI_MOVE:    0";
				ffbot_packets[2] = "FURNI_PUT:     0";

				// commit to file
				File.WriteAllLines(header_file, ffbot_packets);
			}

			// attach 
			Triggers.OutAttach(SPACE_SEL, OnSpaceSelected); // walk packet
			Triggers.InAttach(FURNI_MOVE, OnFurniPlaced); // move packet
			Triggers.InAttach(FURNI_PUT, OnFurniPlaced); // placed packet
			InitializeComponent();
		}

		// Choose Space
		private void chooseSpace_Click(object sender, EventArgs e) {
			chooseFlag = true;
			runFlag = false;
		}

		// Start Bot
		private void start_Click(object sender, EventArgs e) {
			chooseFlag = false;
			runFlag = true;
		}

		// Stop Bot
		private void stop_Click(object sender, EventArgs e) {
			chooseFlag = false;
			runFlag = false;
		}

		// Delay Box
		private void setDelay_Click(object sender, EventArgs e) {
			delay = (int)delayVal.Value;
		}

		protected void OnSpaceSelected(InterceptedEventArgs args) {
			if(chooseFlag) {
				//[0][0][0][10][7]Á[0][0][0][8][0][0][0][7]
				// block the packet
				chooseFlag = false;
				args.IsBlocked = true;

				// parse space
				byte[] data = args.Packet.ToBytes();
				space = new Tuple<int, int>(data[9], data[13]);

				// debug print space
				//string space_string = "(" + space.Item1 + ", " + space.Item2 + ")";
				//Connection.SendToServerAsync(3871, space_string, 4, 0);
			}
		}

		protected void OnFurniPlaced(InterceptedEventArgs args) {
			if(runFlag) {
				// packet ex.
				//[0][0][0]6[5]Ô {×C[0][0][0][0][0][8][0][0][0][3][0][0][0][0][0][3]0.0[0]

				// parse space
				byte[] data = args.Packet.ToBytes();
				Tuple<int, int> furni_space = new Tuple<int, int>(data[17], data[21]);

				// move to that space
				//if (space.Equals(furni_space))
				//{
				System.Threading.Thread.Sleep(delay); // delay
				Connection.SendToServerAsync(SPACE_SEL, furni_space.Item1, furni_space.Item2);
				//}

				// debug print space
				//string space_string = "(" + furni_space.Item1 + ", " + furni_space.Item2 + ")";
				//Connection.SendToServerAsync(3871, space_string, 4, 0);
			}
		}

		private void PacketSubmit_Click(object sender, EventArgs e) {
			// detach packet headers
			Triggers.OutDetach(SPACE_SEL); // walk packet
			Triggers.InDetach(FURNI_MOVE); // move packet
			Triggers.InDetach(FURNI_PUT); // placed packet

			// set packet headers
			ushort.TryParse(SpaceSEL.Text, out SPACE_SEL);
			ushort.TryParse(FurniMOVE.Text, out FURNI_MOVE);
			ushort.TryParse(FurniPUT.Text, out FURNI_PUT);

			// build packet buffer
			string[] ffbot_packets = new String[packet_count];
			ffbot_packets[0] = "SPACE_SEL:     " + SPACE_SEL;
			ffbot_packets[1] = "FURNI_MOVE:    " + FURNI_MOVE;
			ffbot_packets[2] = "FURNI_PUT:     " + FURNI_PUT;

			// commit to file
			File.WriteAllLines(header_file, ffbot_packets);


			// attach packet header
			Triggers.OutAttach(SPACE_SEL, OnSpaceSelected); // walk packet
			Triggers.InAttach(FURNI_MOVE, OnFurniPlaced); // move packet
			Triggers.InAttach(FURNI_PUT, OnFurniPlaced); // placed packet

		}

		private void settings_Load(object sender, EventArgs e) {
			// init settings menu.
			SpaceSEL.Text = SPACE_SEL.ToString();
			FurniMOVE.Text = FURNI_MOVE.ToString();
			FurniPUT.Text = FURNI_PUT.ToString();
		}

	}
}
