namespace LMAOSoft.Inc.Forms.Tools
{
    partial class frm_screen_shot
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
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.ms_main = new System.Windows.Forms.MenuStrip();
            this.tsmi_take_picture = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_upload = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_manage = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.ms_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_image
            // 
            this.pb_image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_image.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pb_image.Location = new System.Drawing.Point(0, 27);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(706, 406);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_image.TabIndex = 3;
            this.pb_image.TabStop = false;
            // 
            // ms_main
            // 
            this.ms_main.AllowMerge = false;
            this.ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_take_picture,
            this.tsmi_upload,
            this.tsmi_manage});
            this.ms_main.Location = new System.Drawing.Point(0, 0);
            this.ms_main.Name = "ms_main";
            this.ms_main.Size = new System.Drawing.Size(706, 24);
            this.ms_main.TabIndex = 2;
            this.ms_main.Text = "menuStrip1";
            // 
            // tsmi_take_picture
            // 
            this.tsmi_take_picture.Name = "tsmi_take_picture";
            this.tsmi_take_picture.Size = new System.Drawing.Size(85, 20);
            this.tsmi_take_picture.Text = "Snap Picture";
            this.tsmi_take_picture.Click += new System.EventHandler(this.tsmi_take_picture_Click);
            // 
            // tsmi_upload
            // 
            this.tsmi_upload.Name = "tsmi_upload";
            this.tsmi_upload.Size = new System.Drawing.Size(57, 20);
            this.tsmi_upload.Text = "Upload";
            this.tsmi_upload.Click += new System.EventHandler(this.tsmi_upload_Click);
            // 
            // tsmi_manage
            // 
            this.tsmi_manage.Name = "tsmi_manage";
            this.tsmi_manage.Size = new System.Drawing.Size(62, 20);
            this.tsmi_manage.Text = "Manage";
            this.tsmi_manage.Click += new System.EventHandler(this.tsmi_manage_Click);
            // 
            // frm_screen_shot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 433);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.ms_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.ms_main;
            this.Name = "frm_screen_shot";
            this.Text = "Xbox 360 Screen Shot";
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ms_main.ResumeLayout(false);
            this.ms_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.ToolStripMenuItem tsmi_take_picture;
        private System.Windows.Forms.ToolStripMenuItem tsmi_upload;
        private System.Windows.Forms.ToolStripMenuItem tsmi_manage;

    }
}