namespace LMAOSoft.Inc.Forms.Tools.Game_Info
{
    partial class frm_game_info_multiple
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pb_package = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pb_content = new System.Windows.Forms.PictureBox();
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
            this.lv_main = new System.Windows.Forms.ListView();
            this.ch_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_title_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cms_game_info = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_select_all = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_send = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_send_selected = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_send_all = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_remove_all = new System.Windows.Forms.ToolStripMenuItem();
            this.ch_hash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_revision = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsmi_remove_duplicates = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_package)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_content)).BeginInit();
            this.cms_game_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.tb_fullDirectory);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_rootFolder);
            this.groupBox1.Controls.Add(this.tb_deviceID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_titleName);
            this.groupBox1.Controls.Add(this.lbl_subFolder);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_titleFolder);
            this.groupBox1.Controls.Add(this.tb_consoleID);
            this.groupBox1.Controls.Add(this.tb_profileID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_display);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_titleID);
            this.groupBox1.Location = new System.Drawing.Point(12, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pb_package);
            this.groupBox2.Location = new System.Drawing.Point(367, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(102, 109);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Package Picture";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pb_content);
            this.groupBox3.Location = new System.Drawing.Point(367, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(102, 109);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Content Picture";
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
            // tb_fullDirectory
            // 
            this.tb_fullDirectory.BackColor = System.Drawing.SystemColors.Control;
            this.tb_fullDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_fullDirectory.Location = new System.Drawing.Point(85, 247);
            this.tb_fullDirectory.Name = "tb_fullDirectory";
            this.tb_fullDirectory.ReadOnly = true;
            this.tb_fullDirectory.Size = new System.Drawing.Size(272, 13);
            this.tb_fullDirectory.TabIndex = 65;
            this.tb_fullDirectory.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Full Directory:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Display Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Device ID:";
            // 
            // lbl_rootFolder
            // 
            this.lbl_rootFolder.AutoSize = true;
            this.lbl_rootFolder.Location = new System.Drawing.Point(82, 181);
            this.lbl_rootFolder.Name = "lbl_rootFolder";
            this.lbl_rootFolder.Size = new System.Drawing.Size(27, 13);
            this.lbl_rootFolder.TabIndex = 63;
            this.lbl_rootFolder.Text = "N/A";
            // 
            // tb_deviceID
            // 
            this.tb_deviceID.Enabled = false;
            this.tb_deviceID.Location = new System.Drawing.Point(91, 74);
            this.tb_deviceID.MaxLength = 40;
            this.tb_deviceID.Name = "tb_deviceID";
            this.tb_deviceID.ReadOnly = true;
            this.tb_deviceID.Size = new System.Drawing.Size(266, 20);
            this.tb_deviceID.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Root Folder:";
            // 
            // tb_titleName
            // 
            this.tb_titleName.Enabled = false;
            this.tb_titleName.Location = new System.Drawing.Point(91, 48);
            this.tb_titleName.Name = "tb_titleName";
            this.tb_titleName.ReadOnly = true;
            this.tb_titleName.Size = new System.Drawing.Size(266, 20);
            this.tb_titleName.TabIndex = 51;
            // 
            // lbl_subFolder
            // 
            this.lbl_subFolder.AutoSize = true;
            this.lbl_subFolder.Location = new System.Drawing.Point(82, 225);
            this.lbl_subFolder.Name = "lbl_subFolder";
            this.lbl_subFolder.Size = new System.Drawing.Size(27, 13);
            this.lbl_subFolder.TabIndex = 61;
            this.lbl_subFolder.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Console ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "Sub Folder:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Title Name:";
            // 
            // lbl_titleFolder
            // 
            this.lbl_titleFolder.AutoSize = true;
            this.lbl_titleFolder.Location = new System.Drawing.Point(82, 203);
            this.lbl_titleFolder.Name = "lbl_titleFolder";
            this.lbl_titleFolder.Size = new System.Drawing.Size(27, 13);
            this.lbl_titleFolder.TabIndex = 59;
            this.lbl_titleFolder.Text = "N/A";
            // 
            // tb_consoleID
            // 
            this.tb_consoleID.Enabled = false;
            this.tb_consoleID.Location = new System.Drawing.Point(91, 126);
            this.tb_consoleID.MaxLength = 8;
            this.tb_consoleID.Name = "tb_consoleID";
            this.tb_consoleID.ReadOnly = true;
            this.tb_consoleID.Size = new System.Drawing.Size(266, 20);
            this.tb_consoleID.TabIndex = 55;
            // 
            // tb_profileID
            // 
            this.tb_profileID.Enabled = false;
            this.tb_profileID.Location = new System.Drawing.Point(91, 100);
            this.tb_profileID.MaxLength = 14;
            this.tb_profileID.Name = "tb_profileID";
            this.tb_profileID.ReadOnly = true;
            this.tb_profileID.Size = new System.Drawing.Size(266, 20);
            this.tb_profileID.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Title Folder:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Title ID:";
            // 
            // tb_display
            // 
            this.tb_display.Enabled = false;
            this.tb_display.Location = new System.Drawing.Point(91, 22);
            this.tb_display.Name = "tb_display";
            this.tb_display.ReadOnly = true;
            this.tb_display.Size = new System.Drawing.Size(266, 20);
            this.tb_display.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Profile ID:";
            // 
            // tb_titleID
            // 
            this.tb_titleID.Enabled = false;
            this.tb_titleID.Location = new System.Drawing.Point(91, 152);
            this.tb_titleID.MaxLength = 8;
            this.tb_titleID.Name = "tb_titleID";
            this.tb_titleID.ReadOnly = true;
            this.tb_titleID.Size = new System.Drawing.Size(266, 20);
            this.tb_titleID.TabIndex = 57;
            // 
            // lv_main
            // 
            this.lv_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_title,
            this.ch_title_name,
            this.ch_status,
            this.ch_hash,
            this.ch_revision});
            this.lv_main.FullRowSelect = true;
            this.lv_main.GridLines = true;
            this.lv_main.Location = new System.Drawing.Point(12, 12);
            this.lv_main.Name = "lv_main";
            this.lv_main.Size = new System.Drawing.Size(484, 272);
            this.lv_main.TabIndex = 1;
            this.lv_main.UseCompatibleStateImageBehavior = false;
            this.lv_main.View = System.Windows.Forms.View.Details;
            this.lv_main.DoubleClick += new System.EventHandler(this.lv_main_DoubleClick);
            this.lv_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lv_main_MouseDown);
            // 
            // ch_title
            // 
            this.ch_title.Text = "Title";
            this.ch_title.Width = 59;
            // 
            // ch_title_name
            // 
            this.ch_title_name.Text = "Title Name";
            this.ch_title_name.Width = 104;
            // 
            // ch_status
            // 
            this.ch_status.Text = "Status";
            this.ch_status.Width = 88;
            // 
            // cms_game_info
            // 
            this.cms_game_info.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_select_all,
            this.tsmi_send,
            this.tsmi_remove,
            this.tsmi_remove_all,
            this.tsmi_remove_duplicates});
            this.cms_game_info.Name = "cms_game_info";
            this.cms_game_info.Size = new System.Drawing.Size(169, 136);
            // 
            // tsmi_select_all
            // 
            this.tsmi_select_all.Name = "tsmi_select_all";
            this.tsmi_select_all.Size = new System.Drawing.Size(168, 22);
            this.tsmi_select_all.Text = "Select All";
            this.tsmi_select_all.Click += new System.EventHandler(this.tsmi_select_all_Click);
            // 
            // tsmi_send
            // 
            this.tsmi_send.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_send_selected,
            this.tsmi_send_all});
            this.tsmi_send.Name = "tsmi_send";
            this.tsmi_send.Size = new System.Drawing.Size(168, 22);
            this.tsmi_send.Text = "Send";
            // 
            // tsmi_send_selected
            // 
            this.tsmi_send_selected.Name = "tsmi_send_selected";
            this.tsmi_send_selected.Size = new System.Drawing.Size(152, 22);
            this.tsmi_send_selected.Text = "Selected";
            this.tsmi_send_selected.Click += new System.EventHandler(this.tsmi_send_selected_Click);
            // 
            // tsmi_send_all
            // 
            this.tsmi_send_all.Name = "tsmi_send_all";
            this.tsmi_send_all.Size = new System.Drawing.Size(152, 22);
            this.tsmi_send_all.Text = "All";
            // 
            // tsmi_remove
            // 
            this.tsmi_remove.Name = "tsmi_remove";
            this.tsmi_remove.Size = new System.Drawing.Size(168, 22);
            this.tsmi_remove.Text = "Remove";
            this.tsmi_remove.Click += new System.EventHandler(this.tsmi_remove_Click);
            // 
            // tsmi_remove_all
            // 
            this.tsmi_remove_all.Name = "tsmi_remove_all";
            this.tsmi_remove_all.Size = new System.Drawing.Size(168, 22);
            this.tsmi_remove_all.Text = "Remove All";
            this.tsmi_remove_all.Click += new System.EventHandler(this.tsmi_remove_all_Click);
            // 
            // ch_hash
            // 
            this.ch_hash.Text = "Hash";
            this.ch_hash.Width = 139;
            // 
            // ch_revision
            // 
            this.ch_revision.Text = "TU";
            // 
            // tsmi_remove_duplicates
            // 
            this.tsmi_remove_duplicates.Name = "tsmi_remove_duplicates";
            this.tsmi_remove_duplicates.Size = new System.Drawing.Size(168, 22);
            this.tsmi_remove_duplicates.Text = "Remove Dulicates";
            this.tsmi_remove_duplicates.Click += new System.EventHandler(this.tsmi_remove_duplicates_Click);
            // 
            // frm_game_info_multiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 574);
            this.Controls.Add(this.lv_main);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(525, 613);
            this.Name = "frm_game_info_multiple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Info";
            this.Load += new System.EventHandler(this.frm_game_info_multiple_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_package)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_content)).EndInit();
            this.cms_game_info.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pb_package;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pb_content;
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
        private System.Windows.Forms.ListView lv_main;
        private System.Windows.Forms.ColumnHeader ch_title;
        private System.Windows.Forms.ColumnHeader ch_title_name;
        private System.Windows.Forms.ColumnHeader ch_status;
        private System.Windows.Forms.ContextMenuStrip cms_game_info;
        private System.Windows.Forms.ToolStripMenuItem tsmi_select_all;
        private System.Windows.Forms.ToolStripMenuItem tsmi_send;
        private System.Windows.Forms.ToolStripMenuItem tsmi_send_selected;
        private System.Windows.Forms.ToolStripMenuItem tsmi_send_all;
        private System.Windows.Forms.ToolStripMenuItem tsmi_remove;
        private System.Windows.Forms.ToolStripMenuItem tsmi_remove_all;
        private System.Windows.Forms.ColumnHeader ch_hash;
        private System.Windows.Forms.ColumnHeader ch_revision;
        private System.Windows.Forms.ToolStripMenuItem tsmi_remove_duplicates;
    }
}