namespace LMAOSoft.Inc.Forms.Apps
{
    partial class frm_xuid
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
            this.btn_halp = new System.Windows.Forms.Button();
            this.btn_set = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_xuid = new System.Windows.Forms.TextBox();
            this.tb_gt = new System.Windows.Forms.TextBox();
            this.btn_get = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_halp
            // 
            this.btn_halp.Location = new System.Drawing.Point(138, 62);
            this.btn_halp.Name = "btn_halp";
            this.btn_halp.Size = new System.Drawing.Size(30, 23);
            this.btn_halp.TabIndex = 13;
            this.btn_halp.Text = "?";
            this.btn_halp.UseVisualStyleBackColor = true;
            this.btn_halp.Click += new System.EventHandler(this.btn_halp_Click);
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(174, 62);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(75, 23);
            this.btn_set.TabIndex = 12;
            this.btn_set.Text = "Set XUID";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "XUID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gamertag:";
            // 
            // tb_xuid
            // 
            this.tb_xuid.Location = new System.Drawing.Point(73, 36);
            this.tb_xuid.MaxLength = 16;
            this.tb_xuid.Name = "tb_xuid";
            this.tb_xuid.Size = new System.Drawing.Size(223, 20);
            this.tb_xuid.TabIndex = 9;
            // 
            // tb_gt
            // 
            this.tb_gt.Location = new System.Drawing.Point(73, 10);
            this.tb_gt.Name = "tb_gt";
            this.tb_gt.Size = new System.Drawing.Size(223, 20);
            this.tb_gt.TabIndex = 8;
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(57, 62);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(75, 23);
            this.btn_get.TabIndex = 7;
            this.btn_get.Text = "Get XUID";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // frm_xuid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 95);
            this.Controls.Add(this.btn_halp);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_xuid);
            this.Controls.Add(this.tb_gt);
            this.Controls.Add(this.btn_get);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_xuid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XUID Spoofer & Grabber";
            this.Load += new System.EventHandler(this.frm_xuid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_halp;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_xuid;
        private System.Windows.Forms.TextBox tb_gt;
        private System.Windows.Forms.Button btn_get;
    }
}