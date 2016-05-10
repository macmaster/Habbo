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

namespace ClientExtraction
{
    public partial class ClientForm : ExtensionForm
    {
        private bool flag = false;
        //private int copyID;

        public ClientForm()
        {
			// set triggers
			Triggers.InAttach(1717, OnDiceIncoming);
			Triggers.InAttach(2364, OnDiceIncoming);
			Triggers.InAttach(1865, OnDiceIncoming);
			Triggers.InAttach(2657, OnDiceIncoming);
            InitializeComponent();
        }

        // flip the habbo chat string
        protected void OnDiceIncoming(InterceptedEventArgs obj)
        {
            if (flag)
            {
				obj.IsBlocked = true;

				/*
                // byteify the packet
                HMessage hmsg = obj.Packet;
                byte[] data = hmsg.ToBytes();

                // parse dice value
                int len = data.Length;
                int val = data[len - 1];

                if (val >= 1 && val <= 6)
                {
                    // build chat string
                    string char_string = "" + val;

                    // print chat string
                    Connection.SendToServerAsync(3871, char_string, 4, 0);
                }
				*/
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
            }
            else
            {
                flag = true;
            }
        }

		private void button2_Click(object sender, EventArgs e) {
			for(int i = 3000; i <= 3040; i++) {
				Connection.SendToServerAsync(2362, i, "", -1);
				if(i % 2 == 0) {
					Connection.SendToServerAsync(2362, 1, "", -1);
					Connection.SendToServerAsync(3548);
					Connection.SendToServerAsync(3247);
					Connection.SendToServerAsync(840);
					System.Threading.Thread.Sleep(2000);
				}
			}
		}
	}
}
