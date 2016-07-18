namespace WallScript {
	partial class WallForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WallForm));
			this.BotTabs = new System.Windows.Forms.TabControl();
			this.BotTab1 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.moveWindow = new System.Windows.Forms.Button();
			this.faceLeft = new System.Windows.Forms.Button();
			this.faceRight = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.lengthY = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.lengthX = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.widthY = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.widthX = new System.Windows.Forms.NumericUpDown();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.SayOUT = new System.Windows.Forms.TextBox();
			this.WindowCLICK = new System.Windows.Forms.TextBox();
			this.WindowMOVE = new System.Windows.Forms.TextBox();
			this.PacketSubmit = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.BotTabs.SuspendLayout();
			this.BotTab1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lengthY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lengthX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.widthY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.widthX)).BeginInit();
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
			this.BotTabs.Location = new System.Drawing.Point(0, 0);
			this.BotTabs.Name = "BotTabs";
			this.BotTabs.SelectedIndex = 0;
			this.BotTabs.Size = new System.Drawing.Size(348, 324);
			this.BotTabs.TabIndex = 15;
			// 
			// BotTab1
			// 
			this.BotTab1.BackColor = System.Drawing.Color.Cornsilk;
			this.BotTab1.BackgroundImage = global::WallScript.Properties.Resources._20150814_175703;
			this.BotTab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BotTab1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.BotTab1.Controls.Add(this.label1);
			this.BotTab1.Controls.Add(this.moveWindow);
			this.BotTab1.Controls.Add(this.faceLeft);
			this.BotTab1.Controls.Add(this.faceRight);
			this.BotTab1.Controls.Add(this.label5);
			this.BotTab1.Controls.Add(this.lengthY);
			this.BotTab1.Controls.Add(this.label4);
			this.BotTab1.Controls.Add(this.lengthX);
			this.BotTab1.Controls.Add(this.label3);
			this.BotTab1.Controls.Add(this.widthY);
			this.BotTab1.Controls.Add(this.label2);
			this.BotTab1.Controls.Add(this.widthX);
			this.BotTab1.Location = new System.Drawing.Point(4, 25);
			this.BotTab1.Margin = new System.Windows.Forms.Padding(0);
			this.BotTab1.Name = "BotTab1";
			this.BotTab1.Size = new System.Drawing.Size(340, 295);
			this.BotTab1.TabIndex = 0;
			this.BotTab1.Text = "ffbot";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(39, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(246, 23);
			this.label1.TabIndex = 26;
			this.label1.Text = "Ronny\'s Window Scripter v1.0";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// moveWindow
			// 
			this.moveWindow.BackColor = System.Drawing.Color.LimeGreen;
			this.moveWindow.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.moveWindow.ForeColor = System.Drawing.Color.Black;
			this.moveWindow.Location = new System.Drawing.Point(104, 233);
			this.moveWindow.Name = "moveWindow";
			this.moveWindow.Size = new System.Drawing.Size(129, 32);
			this.moveWindow.TabIndex = 25;
			this.moveWindow.Text = "move window";
			this.moveWindow.UseVisualStyleBackColor = false;
			this.moveWindow.Click += new System.EventHandler(this.moveWindow_Click);
			// 
			// faceLeft
			// 
			this.faceLeft.BackColor = System.Drawing.Color.Gray;
			this.faceLeft.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.faceLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.faceLeft.Location = new System.Drawing.Point(38, 163);
			this.faceLeft.Name = "faceLeft";
			this.faceLeft.Size = new System.Drawing.Size(105, 32);
			this.faceLeft.TabIndex = 24;
			this.faceLeft.Text = "face left";
			this.faceLeft.UseVisualStyleBackColor = false;
			this.faceLeft.Click += new System.EventHandler(this.faceLeft_Click);
			// 
			// faceRight
			// 
			this.faceRight.BackColor = System.Drawing.Color.Gray;
			this.faceRight.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.faceRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.faceRight.Location = new System.Drawing.Point(193, 163);
			this.faceRight.Name = "faceRight";
			this.faceRight.Size = new System.Drawing.Size(105, 32);
			this.faceRight.TabIndex = 23;
			this.faceRight.Text = "face right";
			this.faceRight.UseVisualStyleBackColor = false;
			this.faceRight.Click += new System.EventHandler(this.faceRight_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.FloralWhite;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label5.Location = new System.Drawing.Point(203, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 27);
			this.label5.TabIndex = 22;
			this.label5.Text = "L.y";
			// 
			// lengthY
			// 
			this.lengthY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.lengthY.Location = new System.Drawing.Point(250, 136);
			this.lengthY.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
			this.lengthY.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            -2147483648});
			this.lengthY.Name = "lengthY";
			this.lengthY.Size = new System.Drawing.Size(48, 23);
			this.lengthY.TabIndex = 21;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(203, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 27);
			this.label4.TabIndex = 20;
			this.label4.Text = "L.x";
			// 
			// lengthX
			// 
			this.lengthX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.lengthX.Location = new System.Drawing.Point(250, 107);
			this.lengthX.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
			this.lengthX.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            -2147483648});
			this.lengthX.Name = "lengthX";
			this.lengthX.Size = new System.Drawing.Size(48, 23);
			this.lengthX.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.FloralWhite;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label3.Location = new System.Drawing.Point(38, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 27);
			this.label3.TabIndex = 18;
			this.label3.Text = "W.y";
			// 
			// widthY
			// 
			this.widthY.Location = new System.Drawing.Point(95, 137);
			this.widthY.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.widthY.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
			this.widthY.Name = "widthY";
			this.widthY.Size = new System.Drawing.Size(32, 23);
			this.widthY.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(38, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 27);
			this.label2.TabIndex = 16;
			this.label2.Text = "W.x";
			// 
			// widthX
			// 
			this.widthX.Location = new System.Drawing.Point(95, 108);
			this.widthX.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.widthX.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
			this.widthX.Name = "widthX";
			this.widthX.Size = new System.Drawing.Size(32, 23);
			this.widthX.TabIndex = 15;
			// 
			// tabPage2
			// 
			this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tabPage2.Controls.Add(this.SayOUT);
			this.tabPage2.Controls.Add(this.WindowCLICK);
			this.tabPage2.Controls.Add(this.WindowMOVE);
			this.tabPage2.Controls.Add(this.PacketSubmit);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.label12);
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
			// SayOUT
			// 
			this.SayOUT.Location = new System.Drawing.Point(213, 51);
			this.SayOUT.Name = "SayOUT";
			this.SayOUT.Size = new System.Drawing.Size(80, 23);
			this.SayOUT.TabIndex = 36;
			// 
			// WindowCLICK
			// 
			this.WindowCLICK.Location = new System.Drawing.Point(213, 108);
			this.WindowCLICK.Name = "WindowCLICK";
			this.WindowCLICK.Size = new System.Drawing.Size(80, 23);
			this.WindowCLICK.TabIndex = 33;
			// 
			// WindowMOVE
			// 
			this.WindowMOVE.Location = new System.Drawing.Point(213, 79);
			this.WindowMOVE.Name = "WindowMOVE";
			this.WindowMOVE.Size = new System.Drawing.Size(80, 23);
			this.WindowMOVE.TabIndex = 32;
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
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.LightCyan;
			this.label9.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(86, 5);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(177, 27);
			this.label9.TabIndex = 30;
			this.label9.Text = "Packet Headers";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.SystemColors.Control;
			this.label10.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
			this.label10.ForeColor = System.Drawing.SystemColors.MenuText;
			this.label10.Location = new System.Drawing.Point(43, 52);
			this.label10.Margin = new System.Windows.Forms.Padding(40);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(78, 19);
			this.label10.TabIndex = 28;
			this.label10.Text = "Say OUT:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.SystemColors.Control;
			this.label11.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
			this.label11.ForeColor = System.Drawing.SystemColors.MenuText;
			this.label11.Location = new System.Drawing.Point(43, 109);
			this.label11.Margin = new System.Windows.Forms.Padding(40);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(115, 19);
			this.label11.TabIndex = 22;
			this.label11.Text = "Window CLICK:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.SystemColors.Control;
			this.label12.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
			this.label12.ForeColor = System.Drawing.SystemColors.MenuText;
			this.label12.Location = new System.Drawing.Point(43, 80);
			this.label12.Margin = new System.Windows.Forms.Padding(40);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(113, 19);
			this.label12.TabIndex = 14;
			this.label12.Text = "Window MOVE:";
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
			// WallForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(344, 321);
			this.Controls.Add(this.BotTabs);
			this.Name = "WallForm";
			this.Text = "Window Scripter";
			this.BotTabs.ResumeLayout(false);
			this.BotTab1.ResumeLayout(false);
			this.BotTab1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.lengthY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lengthX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.widthY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.widthX)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl BotTabs;
		private System.Windows.Forms.TabPage BotTab1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button moveWindow;
		private System.Windows.Forms.Button faceLeft;
		private System.Windows.Forms.Button faceRight;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown lengthY;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown lengthX;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown widthY;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown widthX;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox SayOUT;
		private System.Windows.Forms.TextBox WindowCLICK;
		private System.Windows.Forms.TextBox WindowMOVE;
		private System.Windows.Forms.Button PacketSubmit;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}

