namespace Mimic {
	partial class MimicForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MimicForm));
			this.tab1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.Trade = new System.Windows.Forms.Button();
			this.IDBox = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.stop = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.start = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.TradeStart = new System.Windows.Forms.TextBox();
			this.ShoutOUT = new System.Windows.Forms.TextBox();
			this.ShoutIN = new System.Windows.Forms.TextBox();
			this.SayOUT = new System.Windows.Forms.TextBox();
			this.SayIN = new System.Windows.Forms.TextBox();
			this.PacketSubmit = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.tab1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.IDBox)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// tab1
			// 
			this.tab1.Controls.Add(this.tabPage1);
			this.tab1.Controls.Add(this.tabPage2);
			this.tab1.Controls.Add(this.tabPage3);
			this.tab1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tab1.Location = new System.Drawing.Point(0, -2);
			this.tab1.Name = "tab1";
			this.tab1.SelectedIndex = 0;
			this.tab1.Size = new System.Drawing.Size(348, 324);
			this.tab1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
			this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.tabPage1.Controls.Add(this.Trade);
			this.tabPage1.Controls.Add(this.IDBox);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.stop);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.start);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(340, 295);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "mimic";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// Trade
			// 
			this.Trade.BackColor = System.Drawing.Color.Blue;
			this.Trade.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Trade.Location = new System.Drawing.Point(183, 106);
			this.Trade.Name = "Trade";
			this.Trade.Size = new System.Drawing.Size(113, 31);
			this.Trade.TabIndex = 14;
			this.Trade.Text = "trade";
			this.Trade.UseVisualStyleBackColor = false;
			this.Trade.Click += new System.EventHandler(this.Trade_Click);
			// 
			// IDBox
			// 
			this.IDBox.Location = new System.Drawing.Point(76, 162);
			this.IDBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.IDBox.Name = "IDBox";
			this.IDBox.Size = new System.Drawing.Size(67, 23);
			this.IDBox.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
			this.label3.Location = new System.Drawing.Point(85, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(157, 19);
			this.label3.TabIndex = 12;
			this.label3.Text = "By: Ronny Macmaster";
			// 
			// stop
			// 
			this.stop.BackColor = System.Drawing.Color.Red;
			this.stop.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stop.Location = new System.Drawing.Point(183, 180);
			this.stop.Name = "stop";
			this.stop.Size = new System.Drawing.Size(113, 31);
			this.stop.TabIndex = 11;
			this.stop.Text = "stop mimic";
			this.stop.UseVisualStyleBackColor = false;
			this.stop.Click += new System.EventHandler(this.stop_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
			this.label2.Location = new System.Drawing.Point(69, 137);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 19);
			this.label2.TabIndex = 10;
			this.label2.Text = "Chat ID:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.LightGray;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(38, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(255, 38);
			this.label1.TabIndex = 9;
			this.label1.Text = "Habbo Mimic v1.0";
			// 
			// start
			// 
			this.start.BackColor = System.Drawing.Color.Green;
			this.start.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.start.Location = new System.Drawing.Point(183, 143);
			this.start.Name = "start";
			this.start.Size = new System.Drawing.Size(113, 31);
			this.start.TabIndex = 8;
			this.start.Text = "start mimic";
			this.start.UseVisualStyleBackColor = false;
			this.start.Click += new System.EventHandler(this.start_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.tabPage2.Controls.Add(this.TradeStart);
			this.tabPage2.Controls.Add(this.ShoutOUT);
			this.tabPage2.Controls.Add(this.ShoutIN);
			this.tabPage2.Controls.Add(this.SayOUT);
			this.tabPage2.Controls.Add(this.SayIN);
			this.tabPage2.Controls.Add(this.PacketSubmit);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.pictureBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(340, 295);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "settings";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.tabPage2.Enter += new System.EventHandler(this.settings_Load);
			// 
			// TradeStart
			// 
			this.TradeStart.Location = new System.Drawing.Point(216, 118);
			this.TradeStart.Name = "TradeStart";
			this.TradeStart.Size = new System.Drawing.Size(80, 23);
			this.TradeStart.TabIndex = 36;
			// 
			// ShoutOUT
			// 
			this.ShoutOUT.Location = new System.Drawing.Point(216, 99);
			this.ShoutOUT.Name = "ShoutOUT";
			this.ShoutOUT.Size = new System.Drawing.Size(80, 23);
			this.ShoutOUT.TabIndex = 35;
			// 
			// ShoutIN
			// 
			this.ShoutIN.Location = new System.Drawing.Point(216, 80);
			this.ShoutIN.Name = "ShoutIN";
			this.ShoutIN.Size = new System.Drawing.Size(80, 23);
			this.ShoutIN.TabIndex = 34;
			// 
			// SayOUT
			// 
			this.SayOUT.Location = new System.Drawing.Point(216, 61);
			this.SayOUT.Name = "SayOUT";
			this.SayOUT.Size = new System.Drawing.Size(80, 23);
			this.SayOUT.TabIndex = 33;
			// 
			// SayIN
			// 
			this.SayIN.Location = new System.Drawing.Point(216, 42);
			this.SayIN.Name = "SayIN";
			this.SayIN.Size = new System.Drawing.Size(80, 23);
			this.SayIN.TabIndex = 32;
			// 
			// PacketSubmit
			// 
			this.PacketSubmit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PacketSubmit.Location = new System.Drawing.Point(140, 152);
			this.PacketSubmit.Margin = new System.Windows.Forms.Padding(0);
			this.PacketSubmit.Name = "PacketSubmit";
			this.PacketSubmit.Size = new System.Drawing.Size(62, 26);
			this.PacketSubmit.TabIndex = 31;
			this.PacketSubmit.Text = "submit";
			this.PacketSubmit.UseVisualStyleBackColor = true;
			this.PacketSubmit.Click += new System.EventHandler(this.PacketSubmit_Click);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.LightCyan;
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(86, 5);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(177, 27);
			this.label7.TabIndex = 30;
			this.label7.Text = "Packet Headers";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.SystemColors.Control;
			this.label9.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
			this.label9.ForeColor = System.Drawing.SystemColors.MenuText;
			this.label9.Location = new System.Drawing.Point(46, 119);
			this.label9.Margin = new System.Windows.Forms.Padding(40);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 19);
			this.label9.TabIndex = 28;
			this.label9.Text = "Trade:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.Control;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.SystemColors.MenuText;
			this.label5.Location = new System.Drawing.Point(46, 100);
			this.label5.Margin = new System.Windows.Forms.Padding(40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 19);
			this.label5.TabIndex = 26;
			this.label5.Text = "Shout OUT:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.SystemColors.Control;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.SystemColors.MenuText;
			this.label6.Location = new System.Drawing.Point(46, 81);
			this.label6.Margin = new System.Windows.Forms.Padding(40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 19);
			this.label6.TabIndex = 24;
			this.label6.Text = "Shout IN:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.SystemColors.Control;
			this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.SystemColors.MenuText;
			this.label8.Location = new System.Drawing.Point(46, 62);
			this.label8.Margin = new System.Windows.Forms.Padding(40);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(78, 19);
			this.label8.TabIndex = 22;
			this.label8.Text = "Say OUT:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.Control;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
			this.label4.Location = new System.Drawing.Point(46, 43);
			this.label4.Margin = new System.Windows.Forms.Padding(40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 19);
			this.label4.TabIndex = 14;
			this.label4.Text = "Say IN:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(3, 181);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(334, 121);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.pictureBox2);
			this.tabPage3.Controls.Add(this.richTextBox1);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(340, 295);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "help";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.richTextBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.ForeColor = System.Drawing.Color.DarkGreen;
			this.richTextBox1.Location = new System.Drawing.Point(0, 0);
			this.richTextBox1.Margin = new System.Windows.Forms.Padding(10);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(348, 299);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new System.Drawing.Point(289, 216);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(48, 76);
			this.pictureBox2.TabIndex = 38;
			this.pictureBox2.TabStop = false;
			// 
			// MimicForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 321);
			this.Controls.Add(this.tab1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MimicForm";
			this.Text = "Habbo Mimic v1.0";
			this.tab1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.IDBox)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tab1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button Trade;
		private System.Windows.Forms.NumericUpDown IDBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button stop;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button start;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button PacketSubmit;
		private System.Windows.Forms.TextBox TradeStart;
		private System.Windows.Forms.TextBox ShoutOUT;
		private System.Windows.Forms.TextBox ShoutIN;
		private System.Windows.Forms.TextBox SayOUT;
		private System.Windows.Forms.TextBox SayIN;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}

