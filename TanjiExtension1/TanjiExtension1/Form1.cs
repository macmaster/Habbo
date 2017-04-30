using System;
using System.Text.RegularExpressions;
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
using System.Collections;
using System.Threading;

namespace TanjiExtension1 {
	public partial class Form1 : ExtensionForm {
		// data headers
		protected const int TRADE_START = 265;
		protected const int TRADE_STOP = 1841;
		protected const int DANCE = 1515;
		protected const int MOVE = 3927;
		protected const int SAY_OUT = 94;
		protected const int SAY_IN = 846;
		protected const int CHANGE_MOOD = 3872;

		private int dance = 1;
		private int msg_idx = 0;
		private bool mimicFlag = false;
		private bool tradeFlag = false;
		private bool moodFlag = false;
		private bool danceFlag = false;

		public Form1() {
			// start up the extension form

			Triggers.InAttach(SAY_IN, OnChatIncoming);
			Triggers.OutAttach(TRADE_START, OnPlayerTraded);
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			// send a wave and msg packet
			string msg = "Get rekt bro!!!";
			Connection.SendToServerAsync(DANCE, 1); // dance
			for(int i = 0; i < 20; i++) {
				Connection.SendToServerAsync(SAY_OUT, msg, 4, 0);
				System.Threading.Thread.Sleep(750);
			}
		}

		private void button2_Click(object sender, EventArgs e) {
			// spam the dance
			if(danceFlag) {
				danceFlag = false;
			} else {
				danceFlag = true;
				new Thread(SpamDance).Start();
			}
		}

		private void button3_Click(object sender, EventArgs e) {
			// spam the moodlight
			if(moodFlag) {
				moodFlag = false;
			} else {
				moodFlag = true;
				new Thread(SpamMoodlight).Start();
			}
		}

		private void button4_Click(object sender, EventArgs e) {
			int x = (int)numericUpDown1.Value;
			int y = (int)numericUpDown3.Value;
			int n = (int)numericUpDown4.Value;
			for(int i = 0; i < n; i++) {
				switch(i % 4) {
					case 0:
						Connection.SendToServerAsync(MOVE, x - 1, y + 1); // move 1
																		  //Console.WriteLine(x+1);
						break;
					case 1:
						Connection.SendToServerAsync(MOVE, x + 1, y + 1); // move 1
																		  //Console.WriteLine(x+1);
						break;
					case 2:
						Connection.SendToServerAsync(MOVE, x + 1, y - 1); // move 1
																		  //Console.WriteLine(x-1);
						break;
					case 3:
						Connection.SendToServerAsync(MOVE, x - 1, y - 1); // move 1
																		  //Console.WriteLine(x-1);
						break;
				}
				System.Threading.Thread.Sleep(1000);
			}
		}

		private void button5_Click(object sender, EventArgs e) {
			msg_idx = 0;
			mimicFlag = true;
		}

		private void button6_Click(object sender, EventArgs e) {
			mimicFlag = false;
		}

		protected void OnChatIncoming(InterceptedEventArgs obj) {

			if(mimicFlag) {
				HMessage hmsg = obj.Packet;

				// parse msg length
				byte[] data = hmsg.ToBytes();
				int n = data[11];

				// parse msg string
				List<byte> strlist = data.ToList();
				strlist = strlist.GetRange(12, n + 12);
				string char_string = Encoding.UTF8.GetString(strlist.ToArray());

				// print msg string
				Connection.SendToServerAsync(SAY_OUT, char_string, 4, msg_idx);
			}

		}

		protected void numericUpDown2_ValueChanged(object sender, EventArgs e) {
			dance = (int)numericUpDown2.Value;
			string char_string = dance.ToString();
			//Connection.SendToServerAsync(SAY_OUT, char_string, 4, msg_idx);
		}

		private void button7_Click(object sender, EventArgs e) {
			// trade button clicked
			new Thread(SpamTrade).Start();
		}


		private void button8_Click(object sender, EventArgs e) {
			tradeFlag = true;
		}

		protected void SpamDance() {
			int x = 1;
			while(danceFlag) {
				Connection.SendToServerAsync(DANCE, dance * (x ^= 1)); // dance
				System.Threading.Thread.Sleep(50);
			}
			Connection.SendToServerAsync(DANCE, dance); // dance
			System.Threading.Thread.Sleep(50);
			Connection.SendToServerAsync(DANCE, dance); // dance
		}

		protected void SpamTrade() {
			int user = Decimal.ToInt32(numericUpDown5.Value);
			int delay = 5, period = 1500;
			int k = 15, n = Decimal.ToInt32(numericUpDown6.Value);
			for(int i = 0; i < n; i++) {
				Connection.SendToServerAsync(TRADE_START, user); // trade
				for(int j = 0; j < k; j++) {
					Connection.SendToServerAsync(TRADE_STOP);
					//System.Threading.Thread.Sleep(delay);
				}
				System.Threading.Thread.Sleep(period);
			}
			string msg = String.Format("done..");
			//Connection.SendToServerAsync(SAY_OUT, msg, msg.Length, msg_idx++); // trade
		}

		protected void SpamMoodlight() {
			// packet
			//{l}{u:1803}{i:1}{i:1}{s:#000000}{i:76}{b:True}

			string color = "#0000F0";
			Random rval = new Random();
			int shade = 76;
			byte[] rgb = new byte[3];
			while(moodFlag) {
				rgb[0] += (byte)rval.Next(256);
				rgb[1] += (byte)rval.Next(256);
				rgb[2] += (byte)rval.Next(256);
				color = "#" + BitConverter.ToString(rgb).Replace("-", "");
				Connection.SendToServerAsync(CHANGE_MOOD, 1, 1, color, shade, true); // change mood
				System.Threading.Thread.Sleep(50);
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
				numericUpDown5.Value = tradeID;
				tradeFlag = false;
			}
		}

	}
}
