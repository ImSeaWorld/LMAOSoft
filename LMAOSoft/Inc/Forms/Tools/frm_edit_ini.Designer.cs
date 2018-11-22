namespace LMAOSoft.Inc.Forms.Tools
{
    partial class frm_edit_ini
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
            this.rtb_ini_editor = new System.Windows.Forms.RichTextBox();
            this.ms_ini_main = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_load_console = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_load_file = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_save_console = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_save_computer = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_file_new = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_file_remove_comments = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_ini_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_ini_editor
            // 
            this.rtb_ini_editor.Location = new System.Drawing.Point(0, 27);
            this.rtb_ini_editor.Name = "rtb_ini_editor";
            this.rtb_ini_editor.Size = new System.Drawing.Size(670, 393);
            this.rtb_ini_editor.TabIndex = 0;
            this.rtb_ini_editor.Text = "";
            // 
            // ms_ini_main
            // 
            this.ms_ini_main.AllowMerge = false;
            this.ms_ini_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.ms_ini_main.Location = new System.Drawing.Point(0, 0);
            this.ms_ini_main.Name = "ms_ini_main";
            this.ms_ini_main.Size = new System.Drawing.Size(670, 24);
            this.ms_ini_main.TabIndex = 2;
            this.ms_ini_main.Text = "ms_main";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_load_console,
            this.tsmi_load_file});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // tsmi_load_console
            // 
            this.tsmi_load_console.Name = "tsmi_load_console";
            this.tsmi_load_console.Size = new System.Drawing.Size(148, 22);
            this.tsmi_load_console.Text = "From Console";
            this.tsmi_load_console.Click += new System.EventHandler(this.tsmi_load_console_Click);
            // 
            // tsmi_load_file
            // 
            this.tsmi_load_file.Name = "tsmi_load_file";
            this.tsmi_load_file.Size = new System.Drawing.Size(148, 22);
            this.tsmi_load_file.Text = "From File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_save_console,
            this.tsmi_save_computer});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // tsmi_save_console
            // 
            this.tsmi_save_console.Name = "tsmi_save_console";
            this.tsmi_save_console.Size = new System.Drawing.Size(152, 22);
            this.tsmi_save_console.Text = "To Console";
            this.tsmi_save_console.Click += new System.EventHandler(this.tsmi_save_console_Click);
            // 
            // tsmi_save_computer
            // 
            this.tsmi_save_computer.Name = "tsmi_save_computer";
            this.tsmi_save_computer.Size = new System.Drawing.Size(145, 22);
            this.tsmi_save_computer.Text = "To Computer";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_file_new,
            this.tsmi_file_remove_comments});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmi_file_new
            // 
            this.tsmi_file_new.Name = "tsmi_file_new";
            this.tsmi_file_new.Size = new System.Drawing.Size(179, 22);
            this.tsmi_file_new.Text = "New";
            // 
            // tsmi_file_remove_comments
            // 
            this.tsmi_file_remove_comments.Name = "tsmi_file_remove_comments";
            this.tsmi_file_remove_comments.Size = new System.Drawing.Size(179, 22);
            this.tsmi_file_remove_comments.Text = "Remove Comments";
            this.tsmi_file_remove_comments.Click += new System.EventHandler(this.tsmi_file_remove_comments_Click);
            // 
            // frm_edit_ini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 419);
            this.Controls.Add(this.ms_ini_main);
            this.Controls.Add(this.rtb_ini_editor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.ms_ini_main;
            this.Name = "frm_edit_ini";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".ini Editor";
            this.ms_ini_main.ResumeLayout(false);
            this.ms_ini_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_ini_editor;
        private System.Windows.Forms.MenuStrip ms_ini_main;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_load_console;
        private System.Windows.Forms.ToolStripMenuItem tsmi_load_file;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_save_console;
        private System.Windows.Forms.ToolStripMenuItem tsmi_save_computer;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file_new;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file_remove_comments;
    }
}