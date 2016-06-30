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

namespace TanjiExtension1
{
    public partial class Form1 : ExtensionForm
    {
		// data headers
		protected const int DANCE = 174;
		protected const int MOVE = 3936;
		protected const int SAY_OUT = 2929;
		protected const int SAY_IN = 1089;
		protected const int CHANGE_MOOD = 1803;

		private int dance = 1;
        private int msg_idx = 0;
        private bool mimicFlag = false;

		public Form1()
        {
			// start up the extension form

            Triggers.InAttach(1231, OnChatIncoming);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // send a wave and msg packet
            string msg = "Get rekt bro!!!";
            Connection.SendToServerAsync(DANCE, 1); // dance
            for (int i = 0; i < 20; i++)
            {
                Connection.SendToServerAsync(SAY_OUT, msg, 4, 0);
                System.Threading.Thread.Sleep(750);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 400; i++)
            {
                Connection.SendToServerAsync(DANCE, dance * (i % 2)); // dance
                System.Threading.Thread.Sleep(50);
            }
            Connection.SendToServerAsync(DANCE, dance); // dance
            System.Threading.Thread.Sleep(50);
            Connection.SendToServerAsync(DANCE, dance); // dance

        }

        private void button3_Click(object sender, EventArgs e)
        {
			// packet
			//{l}{u:1803}{i:1}{i:1}{s:#000000}{i:76}{b:True}

			string color = "#0000F0";
			Random rval = new Random();
			int shade = 76;
			byte[] rgb = new byte[3];
			for (int idx = 0x00; idx < 0xFF; idx++)
			//for(shade = 76; shade < 256; shade++)
			{
				rgb[0] += (byte)rval.Next(256);
				rgb[1] += (byte)rval.Next(256);
				rgb[2] += (byte)rval.Next(256);
				color = "#" + BitConverter.ToString(rgb).Replace("-", "");
				Connection.SendToServerAsync(CHANGE_MOOD, 1, 1, color, shade, true); // change mood
				System.Threading.Thread.Sleep(100);
			}
		}

        private void button4_Click(object sender, EventArgs e)
        {
			int x = (int)numericUpDown1.Value;
			int y = (int)numericUpDown3.Value;
			int n = (int)numericUpDown4.Value;
            for (int i = 0; i < n; i++)
            {
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

        private void button5_Click(object sender, EventArgs e)
        {
            msg_idx = 0;
            mimicFlag = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mimicFlag = false;
        }

        protected void OnChatIncoming(InterceptedEventArgs obj)
        {

            if (mimicFlag)
            {
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
	}
}
