namespace LMAOSoft.Inc.Forms.Tools.Sub_Form
{
    partial class frm_sub_screen_shot
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
            this.lv_manage_images = new System.Windows.Forms.ListView();
            this.pb_image_preview = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_imgur_link = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_imgur_delete = new System.Windows.Forms.TextBox();
            this.tb_local_storage = new System.Windows.Forms.TextBox();
            this.ch_file_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_file_creation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_url = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cms_main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgurToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image_preview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.cms_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_manage_images
            // 
            this.lv_manage_images.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_file_name,
            this.ch_file_creation,
            this.ch_url});
            this.lv_manage_images.ContextMenuStrip = this.cms_main;
            this.lv_manage_images.FullRowSelect = true;
            this.lv_manage_images.GridLines = true;
            this.lv_manage_images.Location = new System.Drawing.Point(12, 12);
            this.lv_manage_images.Name = "lv_manage_images";
            this.lv_manage_images.Size = new System.Drawing.Size(408, 302);
            this.lv_manage_images.TabIndex = 0;
            this.lv_manage_images.UseCompatibleStateImageBehavior = false;
            this.lv_manage_images.View = System.Windows.Forms.View.Details;
            this.lv_manage_images.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lv_manage_images_MouseDown);
            // 
            // pb_image_preview
            // 
            this.pb_image_preview.Location = new System.Drawing.Point(6, 19);
            this.pb_image_preview.Name = "pb_image_preview";
            this.pb_image_preview.Size = new System.Drawing.Size(274, 196);
            this.pb_image_preview.TabIndex = 1;
            this.pb_image_preview.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_local_storage);
            this.groupBox1.Controls.Add(this.tb_imgur_delete);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_imgur_link);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pb_image_preview);
            this.groupBox1.Location = new System.Drawing.Point(426, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 302);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Local Storage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Imgur Delete Link:";
            // 
            // tb_imgur_link
            // 
            this.tb_imgur_link.Location = new System.Drawing.Point(116, 221);
            this.tb_imgur_link.Name = "tb_imgur_link";
            this.tb_imgur_link.Size = new System.Drawing.Size(153, 20);
            this.tb_imgur_link.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imgur Link:";
            // 
            // tb_imgur_delete
            // 
            this.tb_imgur_delete.Location = new System.Drawing.Point(116, 247);
            this.tb_imgur_delete.Name = "tb_imgur_delete";
            this.tb_imgur_delete.Size = new System.Drawing.Size(153, 20);
            this.tb_imgur_delete.TabIndex = 6;
            // 
            // tb_local_storage
            // 
            this.tb_local_storage.Location = new System.Drawing.Point(116, 273);
            this.tb_local_storage.Name = "tb_local_storage";
            this.tb_local_storage.Size = new System.Drawing.Size(153, 20);
            this.tb_local_storage.TabIndex = 7;
            // 
            // ch_file_name
            // 
            this.ch_file_name.Text = "File Name";
            this.ch_file_name.Width = 137;
            // 
            // ch_file_creation
            // 
            this.ch_file_creation.Text = "File Created";
            this.ch_file_creation.Width = 125;
            // 
            // ch_url
            // 
            this.ch_url.Text = "URL";
            this.ch_url.Width = 126;
            // 
            // cms_main
            // 
            this.cms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cms_main.Name = "cms_main";
            this.cms_main.Size = new System.Drawing.Size(108, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localToolStripMenuItem,
            this.imgurToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // localToolStripMenuItem
            // 
            this.localToolStripMenuItem.Name = "localToolStripMenuItem";
            this.localToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.localToolStripMenuItem.Text = "Local";
            // 
            // imgurToolStripMenuItem
            // 
            this.imgurToolStripMenuItem.Name = "imgurToolStripMenuItem";
            this.imgurToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.imgurToolStripMenuItem.Text = "Imgur";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locallyToolStripMenuItem,
            this.imgurToolStripMenuItem1});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // locallyToolStripMenuItem
            // 
            this.locallyToolStripMenuItem.Name = "locallyToolStripMenuItem";
            this.locallyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.locallyToolStripMenuItem.Text = "Locally";
            // 
            // imgurToolStripMenuItem1
            // 
            this.imgurToolStripMenuItem1.Name = "imgurToolStripMenuItem1";
            this.imgurToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.imgurToolStripMenuItem1.Text = "Imgur";
            // 
            // frm_sub_screen_shot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 326);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lv_manage_images);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_sub_screen_shot";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Images";
            ((System.ComponentModel.ISupportInitialize)(this.pb_image_preview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cms_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_manage_images;
        private System.Windows.Forms.PictureBox pb_image_preview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_imgur_link;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader ch_file_name;
        private System.Windows.Forms.ColumnHeader ch_file_creation;
        private System.Windows.Forms.ColumnHeader ch_url;
        private System.Windows.Forms.TextBox tb_local_storage;
        private System.Windows.Forms.TextBox tb_imgur_delete;
        private System.Windows.Forms.ContextMenuStrip cms_main;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imgurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imgurToolStripMenuItem1;
    }
}