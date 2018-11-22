namespace LMAOSoft.Inc.Forms.Tools
{
    partial class frm_game_info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_fullDirectory = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_rootFolder = new System.Windows.Forms.Label();
            this.tb_deviceID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_titleName = new System.Windows.Forms.TextBox();
            this.lbl_subFolder = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_titleFolder = new System.Windows.Forms.Label();
            this.tb_consoleID = new System.Windows.Forms.TextBox();
            this.tb_profileID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_display = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_titleID = new System.Windows.Forms.TextBox();
            this.ms_main = new System.Windows.Forms.MenuStrip();
            this.tsmi_file = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_rhr = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_send = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_close = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_package = new System.Windows.Forms.PictureBox();
            this.pb_content = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ms_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_package)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_content)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_fullDirectory
            // 
            this.tb_fullDirectory.BackColor = System.Drawing.SystemColors.Control;
            this.tb_fullDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_fullDirectory.Location = new System.Drawing.Point(87, 261);
            this.tb_fullDirectory.Name = "tb_fullDirectory";
            this.tb_fullDirectory.ReadOnly = true;
            this.tb_fullDirectory.Size = new System.Drawing.Size(272, 13);
            this.tb_fullDirectory.TabIndex = 40;
            this.tb_fullDirectory.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Full Directory:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Display Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Device ID:";
            // 
            // lbl_rootFolder
            // 
            this.lbl_rootFolder.AutoSize = true;
            this.lbl_rootFolder.Location = new System.Drawing.Point(84, 195);
            this.lbl_rootFolder.Name = "lbl_rootFolder";
            this.lbl_rootFolder.Size = new System.Drawing.Size(27, 13);
            this.lbl_rootFolder.TabIndex = 38;
            this.lbl_rootFolder.Text = "N/A";
            // 
            // tb_deviceID
            // 
            this.tb_deviceID.Location = new System.Drawing.Point(87, 88);
            this.tb_deviceID.MaxLength = 40;
            this.tb_deviceID.Name = "tb_deviceID";
            this.tb_deviceID.ReadOnly = true;
            this.tb_deviceID.Size = new System.Drawing.Size(272, 20);
            this.tb_deviceID.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Root Folder:";
            // 
            // tb_titleName
            // 
            this.tb_titleName.Location = new System.Drawing.Point(87, 62);
            this.tb_titleName.Name = "tb_titleName";
            this.tb_titleName.ReadOnly = true;
            this.tb_titleName.Size = new System.Drawing.Size(272, 20);
            this.tb_titleName.TabIndex = 26;
            // 
            // lbl_subFolder
            // 
            this.lbl_subFolder.AutoSize = true;
            this.lbl_subFolder.Location = new System.Drawing.Point(84, 239);
            this.lbl_subFolder.Name = "lbl_subFolder";
            this.lbl_subFolder.Size = new System.Drawing.Size(27, 13);
            this.lbl_subFolder.TabIndex = 36;
            this.lbl_subFolder.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Console ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Sub Folder:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Title Name:";
            // 
            // lbl_titleFolder
            // 
            this.lbl_titleFolder.AutoSize = true;
            this.lbl_titleFolder.Location = new System.Drawing.Point(84, 217);
            this.lbl_titleFolder.Name = "lbl_titleFolder";
            this.lbl_titleFolder.Size = new System.Drawing.Size(27, 13);
            this.lbl_titleFolder.TabIndex = 34;
            this.lbl_titleFolder.Text = "N/A";
            // 
            // tb_consoleID
            // 
            this.tb_consoleID.Location = new System.Drawing.Point(87, 140);
            this.tb_consoleID.MaxLength = 8;
            this.tb_consoleID.Name = "tb_consoleID";
            this.tb_consoleID.ReadOnly = true;
            this.tb_consoleID.Size = new System.Drawing.Size(272, 20);
            this.tb_consoleID.TabIndex = 30;
            // 
            // tb_profileID
            // 
            this.tb_profileID.Location = new System.Drawing.Point(87, 114);
            this.tb_profileID.MaxLength = 14;
            this.tb_profileID.Name = "tb_profileID";
            this.tb_profileID.ReadOnly = true;
            this.tb_profileID.Size = new System.Drawing.Size(272, 20);
            this.tb_profileID.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Title Folder:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Title ID:";
            // 
            // tb_display
            // 
            this.tb_display.Location = new System.Drawing.Point(87, 36);
            this.tb_display.Name = "tb_display";
            this.tb_display.ReadOnly = true;
            this.tb_display.Size = new System.Drawing.Size(272, 20);
            this.tb_display.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Profile ID:";
            // 
            // tb_titleID
            // 
            this.tb_titleID.Location = new System.Drawing.Point(87, 166);
            this.tb_titleID.MaxLength = 8;
            this.tb_titleID.Name = "tb_titleID";
            this.tb_titleID.ReadOnly = true;
            this.tb_titleID.Size = new System.Drawing.Size(272, 20);
            this.tb_titleID.TabIndex = 32;
            // 
            // ms_main
            // 
            this.ms_main.AllowMerge = false;
            this.ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_file,
            this.tsmi_close});
            this.ms_main.Location = new System.Drawing.Point(0, 0);
            this.ms_main.Name = "ms_main";
            this.ms_main.Size = new System.Drawing.Size(484, 24);
            this.ms_main.TabIndex = 41;
            this.ms_main.Text = "ms_main";
            // 
            // tsmi_file
            // 
            this.tsmi_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_rhr,
            this.tsmi_send});
            this.tsmi_file.Name = "tsmi_file";
            this.tsmi_file.Size = new System.Drawing.Size(37, 20);
            this.tsmi_file.Text = "File";
            // 
            // tsmi_rhr
            // 
            this.tsmi_rhr.Name = "tsmi_rhr";
            this.tsmi_rhr.Size = new System.Drawing.Size(173, 22);
            this.tsmi_rhr.Text = "Rehash and Resign";
            // 
            // tsmi_send
            // 
            this.tsmi_send.Name = "tsmi_send";
            this.tsmi_send.Size = new System.Drawing.Size(173, 22);
            this.tsmi_send.Text = "Send To Console";
            this.tsmi_send.Click += new System.EventHandler(this.tsmi_send_Click);
            // 
            // tsmi_close
            // 
            this.tsmi_close.Name = "tsmi_close";
            this.tsmi_close.Size = new System.Drawing.Size(48, 20);
            this.tsmi_close.Text = "Close";
            this.tsmi_close.Click += new System.EventHandler(this.tsmi_close_Click);
            // 
            // pb_package
            // 
            this.pb_package.Image = global::LMAOSoft.Properties.Resources.empty;
            this.pb_package.Location = new System.Drawing.Point(11, 19);
            this.pb_package.Name = "pb_package";
            this.pb_package.Size = new System.Drawing.Size(80, 80);
            this.pb_package.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_package.TabIndex = 43;
            this.pb_package.TabStop = false;
            // 
            // pb_content
            // 
            this.pb_content.Image = global::LMAOSoft.Properties.Resources.empty;
            this.pb_content.Location = new System.Drawing.Point(11, 19);
            this.pb_content.Name = "pb_content";
            this.pb_content.Size = new System.Drawing.Size(80, 80);
            this.pb_content.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_content.TabIndex = 42;
            this.pb_content.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pb_content);
            this.groupBox1.Location = new System.Drawing.Point(369, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 109);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Content Picture";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pb_package);
            this.groupBox2.Location = new System.Drawing.Point(369, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(102, 109);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Package Picture";
            // 
            // frm_game_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 287);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ms_main);
            this.Controls.Add(this.tb_fullDirectory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_rootFolder);
            this.Controls.Add(this.tb_deviceID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_titleName);
            this.Controls.Add(this.lbl_subFolder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_titleFolder);
            this.Controls.Add(this.tb_consoleID);
            this.Controls.Add(this.tb_profileID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_display);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_titleID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frm_game_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Info";
            this.Load += new System.EventHandler(this.frm_game_info_Load);
            this.ms_main.ResumeLayout(false);
            this.ms_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_package)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_content)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_fullDirectory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_rootFolder;
        private System.Windows.Forms.TextBox tb_deviceID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_titleName;
        private System.Windows.Forms.Label lbl_subFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_titleFolder;
        private System.Windows.Forms.TextBox tb_consoleID;
        private System.Windows.Forms.TextBox tb_profileID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_display;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_titleID;
        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file;
        private System.Windows.Forms.ToolStripMenuItem tsmi_rhr;
        private System.Windows.Forms.ToolStripMenuItem tsmi_send;
        private System.Windows.Forms.ToolStripMenuItem tsmi_close;
        private System.Windows.Forms.PictureBox pb_package;
        private System.Windows.Forms.PictureBox pb_content;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}