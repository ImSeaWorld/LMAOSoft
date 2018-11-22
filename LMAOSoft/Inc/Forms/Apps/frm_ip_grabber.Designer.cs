namespace LMAOSoft.Inc.Forms.Apps
{
    partial class frm_ip_grabber
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
            this.btn_grab = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_autoRefresh = new System.Windows.Forms.CheckBox();
            this.cb_log = new System.Windows.Forms.CheckBox();
            this.lv_info = new System.Windows.Forms.ListView();
            this.ch_gt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_ip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cms_main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_copy_gamertag = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_copy_ip = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_copy_both = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_get_xuid = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.cms_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_grab
            // 
            this.btn_grab.Location = new System.Drawing.Point(12, 390);
            this.btn_grab.Name = "btn_grab";
            this.btn_grab.Size = new System.Drawing.Size(257, 23);
            this.btn_grab.TabIndex = 5;
            this.btn_grab.Text = "Nub IPs";
            this.btn_grab.UseVisualStyleBackColor = true;
            this.btn_grab.Click += new System.EventHandler(this.btn_grab_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_autoRefresh);
            this.groupBox2.Controls.Add(this.cb_log);
            this.groupBox2.Location = new System.Drawing.Point(12, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 50);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // cb_autoRefresh
            // 
            this.cb_autoRefresh.AutoSize = true;
            this.cb_autoRefresh.Location = new System.Drawing.Point(125, 22);
            this.cb_autoRefresh.Name = "cb_autoRefresh";
            this.cb_autoRefresh.Size = new System.Drawing.Size(120, 17);
            this.cb_autoRefresh.TabIndex = 2;
            this.cb_autoRefresh.Text = "Auto-Refresh(5 sec)";
            this.cb_autoRefresh.UseVisualStyleBackColor = true;
            // 
            // cb_log
            // 
            this.cb_log.AutoSize = true;
            this.cb_log.Checked = true;
            this.cb_log.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_log.Location = new System.Drawing.Point(18, 22);
            this.cb_log.Name = "cb_log";
            this.cb_log.Size = new System.Drawing.Size(108, 17);
            this.cb_log.TabIndex = 0;
            this.cb_log.Text = "Log All Pulled IPs";
            this.cb_log.UseVisualStyleBackColor = true;
            // 
            // lv_info
            // 
            this.lv_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_gt,
            this.ch_ip});
            this.lv_info.FullRowSelect = true;
            this.lv_info.GridLines = true;
            this.lv_info.Location = new System.Drawing.Point(12, 66);
            this.lv_info.Name = "lv_info";
            this.lv_info.Size = new System.Drawing.Size(257, 318);
            this.lv_info.TabIndex = 4;
            this.lv_info.UseCompatibleStateImageBehavior = false;
            this.lv_info.View = System.Windows.Forms.View.Details;
            // 
            // ch_gt
            // 
            this.ch_gt.Text = "Gamer Tag";
            this.ch_gt.Width = 133;
            // 
            // ch_ip
            // 
            this.ch_ip.Text = "IP";
            this.ch_ip.Width = 120;
            // 
            // cms_main
            // 
            this.cms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_copy,
            this.tsmi_get_xuid});
            this.cms_main.Name = "cms_main";
            this.cms_main.ShowImageMargin = false;
            this.cms_main.Size = new System.Drawing.Size(128, 70);
            // 
            // tsmi_copy
            // 
            this.tsmi_copy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_copy_gamertag,
            this.tsmi_copy_ip,
            this.tsmi_copy_both});
            this.tsmi_copy.Name = "tsmi_copy";
            this.tsmi_copy.Size = new System.Drawing.Size(127, 22);
            this.tsmi_copy.Text = "Copy";
            // 
            // tsmi_copy_gamertag
            // 
            this.tsmi_copy_gamertag.Name = "tsmi_copy_gamertag";
            this.tsmi_copy_gamertag.Size = new System.Drawing.Size(152, 22);
            this.tsmi_copy_gamertag.Text = "Gamertag";
            this.tsmi_copy_gamertag.Click += new System.EventHandler(this.tsmi_copy_gamertag_Click);
            // 
            // tsmi_copy_ip
            // 
            this.tsmi_copy_ip.Name = "tsmi_copy_ip";
            this.tsmi_copy_ip.Size = new System.Drawing.Size(152, 22);
            this.tsmi_copy_ip.Text = "IP";
            this.tsmi_copy_ip.Click += new System.EventHandler(this.tsmi_copy_ip_Click);
            // 
            // tsmi_copy_both
            // 
            this.tsmi_copy_both.Name = "tsmi_copy_both";
            this.tsmi_copy_both.Size = new System.Drawing.Size(152, 22);
            this.tsmi_copy_both.Text = "Both";
            this.tsmi_copy_both.Click += new System.EventHandler(this.tsmi_copy_both_Click);
            // 
            // tsmi_get_xuid
            // 
            this.tsmi_get_xuid.Name = "tsmi_get_xuid";
            this.tsmi_get_xuid.Size = new System.Drawing.Size(127, 22);
            this.tsmi_get_xuid.Text = "Get XUID";
            this.tsmi_get_xuid.Click += new System.EventHandler(this.tsmi_get_xuid_Click);
            // 
            // frm_ip_grabber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 422);
            this.Controls.Add(this.btn_grab);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lv_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_ip_grabber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IP Grabber";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.cms_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_grab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_autoRefresh;
        private System.Windows.Forms.CheckBox cb_log;
        private System.Windows.Forms.ListView lv_info;
        private System.Windows.Forms.ColumnHeader ch_gt;
        private System.Windows.Forms.ColumnHeader ch_ip;
        private System.Windows.Forms.ContextMenuStrip cms_main;
        private System.Windows.Forms.ToolStripMenuItem tsmi_copy;
        private System.Windows.Forms.ToolStripMenuItem tsmi_copy_gamertag;
        private System.Windows.Forms.ToolStripMenuItem tsmi_copy_ip;
        private System.Windows.Forms.ToolStripMenuItem tsmi_copy_both;
        private System.Windows.Forms.ToolStripMenuItem tsmi_get_xuid;
    }
}