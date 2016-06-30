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

namespace Mimic
{
    public partial class MimicForm : ExtensionForm
    {
		// chat packet headers
		public const int SAY_IN = 1089;
		public const int SAY_OUT = 2929;
		public const int SHOUT_IN = 3813;
		public const int SHOUT_OUT = 2336;

		// trade headers
		public const int TRADE_START = 3622;
		public const int TRADE_STOP = 1897;


		private bool mimicFlag = false;
		private int copyID;

        public MimicForm()
        {
            // init copy
            copyID = 0;

            // set triggers
            Triggers.InAttach(SHOUT_IN, OnShoutIncoming);
            Triggers.InAttach(SAY_IN, OnChatIncoming);
            InitializeComponent();
        }

        // flip the habbo chat string
        protected void OnChatIncoming(InterceptedEventArgs obj)
        {

            if (mimicFlag)
            {
                // byteify the packet
                HMessage hmsg = obj.Packet;
                byte[] data = hmsg.ToBytes();

                // parse msg length and sender key
                int sender = data[9] + (data[8] << 8);
                int len = data[11];

                if (sender == copyID)
                {
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
        protected void OnShoutIncoming(InterceptedEventArgs obj)
        {

            if (mimicFlag)
            {
                // byteify the packet
                HMessage hmsg = obj.Packet;
                byte[] data = hmsg.ToBytes();

                // parse msg length and sender key
                int sender = data[9] + (data[8] << 8);
                int len = data[11];

                if (sender == copyID)
                {
                    // parse msg string
                    List<byte> strlist = data.ToList();
                    strlist = strlist.GetRange(12, len + 12);
                    string char_string = Encoding.UTF8.GetString(strlist.ToArray());

                    // print msg string
                    Connection.SendToServerAsync(SHOUT_OUT, char_string, 0);
                }
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            // clear text box and begin mimic
            copyID = (int)IDBox.Value;
            mimicFlag = true;

        }

        private void stop_Click(object sender, EventArgs e)
        {
            mimicFlag = false;
        }

		private void Trade_Click(object sender, EventArgs e) {
			for(int idx = 0; idx < 5; idx++) {
				Connection.SendToServerAsync(TRADE_START, copyID);
					Connection.SendToServerAsync(TRADE_STOP);
					System.Threading.Thread.Sleep(5);
				//for(int jdx = 0; jdx < 5; jdx++) {
				//}
				System.Threading.Thread.Sleep(2000);
			}
		}
	}
}
