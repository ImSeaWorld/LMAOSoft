namespace LMAOSoft.Inc.Forms.Tools
{
    partial class frm_kv_vault
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_kv_vault));
            this.lv_vault_list = new System.Windows.Forms.ListView();
            this.ch_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_last_checked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ms_main = new System.Windows.Forms.MenuStrip();
            this.tsmi_file = new System.Windows.Forms.ToolStripMenuItem();
            this.addKVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_security = new System.Windows.Forms.ToolStripMenuItem();
            this.lockVaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ch_md5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.ms_main.SuspendLayout();
            this.cms_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_vault_list
            // 
            this.lv_vault_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_vault_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_num,
            this.ch_type,
            this.ch_md5,
            this.ch_last_checked,
            this.ch_status});
            this.lv_vault_list.FullRowSelect = true;
            this.lv_vault_list.GridLines = true;
            this.lv_vault_list.Location = new System.Drawing.Point(0, 27);
            this.lv_vault_list.Name = "lv_vault_list";
            this.lv_vault_list.Size = new System.Drawing.Size(393, 264);
            this.lv_vault_list.TabIndex = 0;
            this.lv_vault_list.UseCompatibleStateImageBehavior = false;
            this.lv_vault_list.View = System.Windows.Forms.View.Details;
            // 
            // ch_num
            // 
            this.ch_num.Text = "#";
            this.ch_num.Width = 22;
            // 
            // ch_type
            // 
            this.ch_type.Text = "Type";
            this.ch_type.Width = 43;
            // 
            // ch_last_checked
            // 
            this.ch_last_checked.Text = "Checked";
            this.ch_last_checked.Width = 108;
            // 
            // ch_status
            // 
            this.ch_status.Text = "Status";
            this.ch_status.Width = 68;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Debug";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(356, 62);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // ms_main
            // 
            this.ms_main.AllowMerge = false;
            this.ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_file,
            this.tsmi_security,
            this.tsmi_settings});
            this.ms_main.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ms_main.Location = new System.Drawing.Point(0, 0);
            this.ms_main.Name = "ms_main";
            this.ms_main.Size = new System.Drawing.Size(393, 24);
            this.ms_main.TabIndex = 2;
            this.ms_main.Text = "menuStrip1";
            // 
            // tsmi_file
            // 
            this.tsmi_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addKVToolStripMenuItem});
            this.tsmi_file.Name = "tsmi_file";
            this.tsmi_file.Size = new System.Drawing.Size(37, 20);
            this.tsmi_file.Text = "File";
            // 
            // addKVToolStripMenuItem
            // 
            this.addKVToolStripMenuItem.Name = "addKVToolStripMenuItem";
            this.addKVToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.addKVToolStripMenuItem.Text = "Add KV";
            // 
            // tsmi_security
            // 
            this.tsmi_security.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockVaultToolStripMenuItem});
            this.tsmi_security.Name = "tsmi_security";
            this.tsmi_security.Size = new System.Drawing.Size(61, 20);
            this.tsmi_security.Text = "Security";
            // 
            // lockVaultToolStripMenuItem
            // 
            this.lockVaultToolStripMenuItem.Name = "lockVaultToolStripMenuItem";
            this.lockVaultToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.lockVaultToolStripMenuItem.Text = "Lock Vault";
            // 
            // tsmi_settings
            // 
            this.tsmi_settings.Name = "tsmi_settings";
            this.tsmi_settings.Size = new System.Drawing.Size(61, 20);
            this.tsmi_settings.Text = "Settings";
            // 
            // cms_main
            // 
            this.cms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkToolStripMenuItem,
            this.checkAllToolStripMenuItem,
            this.sendToConsoleToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cms_main.Name = "cms_main";
            this.cms_main.Size = new System.Drawing.Size(164, 92);
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.checkToolStripMenuItem.Text = "Check";
            // 
            // checkAllToolStripMenuItem
            // 
            this.checkAllToolStripMenuItem.Name = "checkAllToolStripMenuItem";
            this.checkAllToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.checkAllToolStripMenuItem.Text = "Check All";
            // 
            // sendToConsoleToolStripMenuItem
            // 
            this.sendToConsoleToolStripMenuItem.Name = "sendToConsoleToolStripMenuItem";
            this.sendToConsoleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.sendToConsoleToolStripMenuItem.Text = "Send To Console";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // ch_md5
            // 
            this.ch_md5.Text = "MD5";
            this.ch_md5.Width = 124;
            // 
            // frm_kv_vault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 396);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lv_vault_list);
            this.Controls.Add(this.ms_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_main;
            this.MinimumSize = new System.Drawing.Size(311, 435);
            this.Name = "frm_kv_vault";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KV Vault (Unlocked)";
            this.groupBox1.ResumeLayout(false);
            this.ms_main.ResumeLayout(false);
            this.ms_main.PerformLayout();
            this.cms_main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_vault_list;
        private System.Windows.Forms.ColumnHeader ch_num;
        private System.Windows.Forms.ColumnHeader ch_type;
        private System.Windows.Forms.ColumnHeader ch_last_checked;
        private System.Windows.Forms.ColumnHeader ch_status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.ToolStripMenuItem tsmi_security;
        private System.Windows.Forms.ToolStripMenuItem lockVaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_settings;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file;
        private System.Windows.Forms.ToolStripMenuItem addKVToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cms_main;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader ch_md5;
    }
}