namespace LMAOSoft.Inc.Forms.Tools.Sub_Form
{
    partial class frm_sub_edit_ini
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_this_one = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_recovered_drive = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Drive:";
            // 
            // btn_this_one
            // 
            this.btn_this_one.Location = new System.Drawing.Point(182, 43);
            this.btn_this_one.Name = "btn_this_one";
            this.btn_this_one.Size = new System.Drawing.Size(49, 23);
            this.btn_this_one.TabIndex = 2;
            this.btn_this_one.Text = "Disun";
            this.btn_this_one.UseVisualStyleBackColor = true;
            this.btn_this_one.Click += new System.EventHandler(this.btn_this_one_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please choose the storage device to get the launch.ini from. It will also be save" +
    "d here.";
            // 
            // cb_recovered_drive
            // 
            this.cb_recovered_drive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_recovered_drive.FormattingEnabled = true;
            this.cb_recovered_drive.Location = new System.Drawing.Point(56, 45);
            this.cb_recovered_drive.Name = "cb_recovered_drive";
            this.cb_recovered_drive.Size = new System.Drawing.Size(120, 21);
            this.cb_recovered_drive.TabIndex = 0;
            // 
            // frm_sub_edit_ini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 77);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_this_one);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_recovered_drive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_sub_edit_ini";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Found More Than One";
            this.Load += new System.EventHandler(this.frm_sub_edit_ini_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_this_one;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_recovered_drive;
    }
}