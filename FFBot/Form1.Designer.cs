namespace FFBot {
	partial class BotForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotForm));
			this.BotTabs = new System.Windows.Forms.TabControl();
			this.BotTab1 = new System.Windows.Forms.TabPage();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.start = new System.Windows.Forms.Button();
			this.stop = new System.Windows.Forms.Button();
			this.chooseSpace = new System.Windows.Forms.Button();
			this.setDelay = new System.Windows.Forms.Button();
			this.delayVal = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.SpaceSEL = new System.Windows.Forms.TextBox();
			this.FurniPUT = new System.Windows.Forms.TextBox();
			this.FurniMOVE = new System.Windows.Forms.TextBox();
			this.PacketSubmit = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.BotTabs.SuspendLayout();
			this.BotTab1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.delayVal)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// BotTabs
			// 
			this.BotTabs.Controls.Add(this.BotTab1);
			this.BotTabs.Controls.Add(this.tabPage2);
			this.BotTabs.Controls.Add(this.tabPage3);
			this.BotTabs.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BotTabs.Location = new System.Drawing.Point(0, -2);
			this.BotTabs.Name = "BotTabs";
			this.BotTabs.SelectedIndex = 0;
			this.BotTabs.Size = new System.Drawing.Size(348, 324);
			this.BotTabs.TabIndex = 0;
			// 
			// BotTab1
			// 
			this.BotTab1.BackColor = System.Drawing.Color.Cornsilk;
			this.BotTab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.BotTab1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.BotTab1.Controls.Add(this.label3);
			this.BotTab1.Controls.Add(this.label1);
			this.BotTab1.Controls.Add(this.start);
			this.BotTab1.Controls.Add(this.stop);
			this.BotTab1.Controls.Add(this.chooseSpace);
			this.BotTab1.Controls.Add(this.setDelay);
			this.BotTab1.Controls.Add(this.delayVal);
			this.BotTab1.Controls.Add(this.label2);
			this.BotTab1.Location = new System.Drawing.Point(4, 25);
			this.BotTab1.Margin = new System.Windows.Forms.Padding(0);
			this.BotTab1.Name = "BotTab1";
			this.BotTab1.Size = new System.Drawing.Size(340, 295);
			this.BotTab1.TabIndex = 0;
			this.BotTab1.Text = "ffbot";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
			this.label3.Location = new System.Drawing.Point(90, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(157, 19);
			this.label3.TabIndex = 16;
			this.label3.Text = "By: Ronny Macmaster";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.LightPink;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label1.Location = new System.Drawing.Point(67, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(204, 27);
			this.label1.TabIndex = 15;
			this.label1.Text = "Ronny\'s FF Bot v2.0";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// start
			// 
			this.start.BackColor = System.Drawing.Color.Green;
			this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.start.ForeColor = System.Drawing.SystemColors.ControlText;
			this.start.Location = new System.Drawing.Point(100, 128);
			this.start.Name = "start";
			this.start.Size = new System.Drawing.Size(138, 34);
			this.start.TabIndex = 1;
			this.start.Text = "Start Bot";
			this.start.UseVisualStyleBackColor = false;
			this.start.Click += new System.EventHandler(this.start_Click);
			// 
			// stop
			// 
			this.stop.BackColor = System.Drawing.Color.Red;
			this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stop.ForeColor = System.Drawing.SystemColors.ControlText;
			this.stop.Location = new System.Drawing.Point(100, 183);
			this.stop.Name = "stop";
			this.stop.Size = new System.Drawing.Size(138, 34);
			this.stop.TabIndex = 2;
			this.stop.Text = "Stop Bot";
			this.stop.UseVisualStyleBackColor = false;
			this.stop.Click += new System.EventHandler(this.stop_Click);
			// 
			// chooseSpace
			// 
			this.chooseSpace.BackColor = System.Drawing.Color.LightSkyBlue;
			this.chooseSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chooseSpace.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chooseSpace.Location = new System.Drawing.Point(100, 78);
			this.chooseSpace.Name = "chooseSpace";
			this.chooseSpace.Size = new System.Drawing.Size(138, 34);
			this.chooseSpace.TabIndex = 0;
			this.chooseSpace.Text = "Choose Space";
			this.chooseSpace.UseVisualStyleBackColor = false;
			this.chooseSpace.Click += new System.EventHandler(this.chooseSpace_Click);
			// 
			// setDelay
			// 
			this.setDelay.Font = new System.Drawing.Font("Comic Sans MS", 10F);
			this.setDelay.Location = new System.Drawing.Point(214, 242);
			this.setDelay.Name = "setDelay";
			this.setDelay.Size = new System.Drawing.Size(75, 23);
			this.setDelay.TabIndex = 6;
			this.setDelay.Text = "set";
			this.setDelay.UseVisualStyleBackColor = true;
			this.setDelay.Click += new System.EventHandler(this.setDelay_Click);
			// 
			// delayVal
			// 
			this.delayVal.Location = new System.Drawing.Point(143, 242);
			this.delayVal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.delayVal.Name = "delayVal";
			this.delayVal.Size = new System.Drawing.Size(50, 23);
			this.delayVal.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(72, 242);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Delay";
			// 
			// tabPage2
			// 
			this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tabPage2.Controls.Add(this.SpaceSEL);
			this.tabPage2.Controls.Add(this.FurniPUT);
			this.tabPage2.Controls.Add(this.FurniMOVE);
			this.tabPage2.Controls.Add(this.PacketSubmit);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.label9);
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
			// SpaceSEL
			// 
			this.SpaceSEL.Location = new System.Drawing.Point(213, 51);
			this.SpaceSEL.Name = "SpaceSEL";
			this.SpaceSEL.Size = new System.Drawing.Size(80, 23);
			this.SpaceSEL.TabIndex = 36;
			// 
			// FurniPUT
			// 
			this.FurniPUT.Location = new System.Drawing.Point(213, 108);
			this.FurniPUT.Name = "FurniPUT";
			this.FurniPUT.Size = new System.Drawing.Size(80, 23);
			this.FurniPUT.TabIndex = 33;
			// 
			// FurniMOVE
			// 
			this.FurniMOVE.Location = new System.Drawing.Point(213, 79);
			this.FurniMOVE.Name = "FurniMOVE";
			this.FurniMOVE.Size = new System.Drawing.Size(80, 23);
			this.FurniMOVE.TabIndex = 32;
			// 
			// PacketSubmit
			// 
			this.PacketSubmit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PacketSubmit.Location = new System.Drawing.Point(140, 143);
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
			this.label9.Location = new System.Drawing.Point(43, 52);
			this.label9.Margin = new System.Windows.Forms.Padding(40);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(116, 19);
			this.label9.TabIndex = 28;
			this.label9.Text = "Space SELECT:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.SystemColors.Control;
			this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.SystemColors.MenuText;
			this.label8.Location = new System.Drawing.Point(43, 109);
			this.label8.Margin = new System.Windows.Forms.Padding(40);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(82, 19);
			this.label8.TabIndex = 22;
			this.label8.Text = "Furni PUT:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.Control;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
			this.label4.Location = new System.Drawing.Point(43, 80);
			this.label4.Margin = new System.Windows.Forms.Padding(40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 19);
			this.label4.TabIndex = 14;
			this.label4.Text = "Furni MOVE:";
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
			// BotForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(347, 321);
			this.Controls.Add(this.BotTabs);
			this.MaximizeBox = false;
			this.Name = "BotForm";
			this.Text = "Ronny\'s FF Bot v2.0";
			this.BotTabs.ResumeLayout(false);
			this.BotTab1.ResumeLayout(false);
			this.BotTab1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.delayVal)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl BotTabs;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button PacketSubmit;
		private System.Windows.Forms.TextBox SpaceSEL;
		private System.Windows.Forms.TextBox FurniPUT;
		private System.Windows.Forms.TextBox FurniMOVE;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TabPage BotTab1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button start;
		private System.Windows.Forms.Button stop;
		private System.Windows.Forms.Button chooseSpace;
		private System.Windows.Forms.Button setDelay;
		private System.Windows.Forms.NumericUpDown delayVal;
		private System.Windows.Forms.Label label2;
	}
}

