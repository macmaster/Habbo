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

namespace FridgeGame{
	public partial class Form1 : ExtensionForm {
		protected const int GET_ITEM = 3243;
		protected const int DROP_ITEM = 3883;
		protected const int ITEM_RECEIVED = 3011;

		private bool runFlag = false;
		private bool chooseFlag = false;

		private int fridgeID = 0;

		public Form1() {
			// attach 
			Triggers.OutAttach(GET_ITEM, OnFridgeSelected); // get_item packet
			Triggers.InAttach(ITEM_RECEIVED, OnItemReceived); // get_item packet
			InitializeComponent();
		}

		// Choose Space
		private void button2_Click(object sender, EventArgs e) {
			chooseFlag = true;
			runFlag = false;
		}

		// Start Bot
		private void button3_Click(object sender, EventArgs e) {
			chooseFlag = false;
			runFlag = true;
		}

		// Stop Bot
		private void button4_Click(object sender, EventArgs e) {
			chooseFlag = false;
			runFlag = false;
		}

		protected void OnFridgeSelected(InterceptedEventArgs args) {
			if(chooseFlag) {
				// block the packet
				chooseFlag = false;
				args.IsBlocked = true;

				// parse space
				byte[] data = args.Packet.ToBytes();
				fridgeID = args.Packet.ReadInteger();

				// debug fridgeID
				Connection.SendToServerAsync(1713, fridgeID.ToString()); //motto
			}
		}

		protected void OnItemReceived(InterceptedEventArgs args) {
			if(runFlag) {
				// packet ex.
				//[0][0][0][10][11]Ã[0][0][0][0][0][0][0][4]

				// parse item
				byte[] data = args.Packet.ToBytes();
				int handItem = (int)data[data.Length - 1]; // last element

				// drop the item if carrot
				if(handItem == 3) {
					Connection.SendToServerAsync(DROP_ITEM);
					//Connection.SendToServerAsync(389, "Carrot!!", 4, 0);
					Connection.SendToServerAsync(GET_ITEM, fridgeID, 0);
				}
			}
		}

	}
}
