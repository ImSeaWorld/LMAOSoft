namespace LMAOSoft
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.gb_consoleInformation = new System.Windows.Forms.GroupBox();
            this.lbl_ram = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_mobo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_gpu = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_cpu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_active_threads = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_current_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ms_main = new System.Windows.Forms.MenuStrip();
            this.tsmi_connect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_con_default = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_con_add_new = new System.Windows.Forms.ToolStripMenuItem();
            this.tstb_con_new = new System.Windows.Forms.ToolStripTextBox();
            this.tsmi_con_set_default = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_reboot = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_reboot_cold = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_reboot_title = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_reboot_active = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_reboot_shutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_tools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_tools_file_browser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_tools_ini_editor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_tools_swap_kv = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_tools_screen_shot = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_tools_debug = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_debug_console_output = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_debug_dump_memory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_tools_apps = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_apps_ip_grabber = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_apps_ip_spoofer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_apps_xuid_spoofer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_kv_vault = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_game_info = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_consoleInformation.SuspendLayout();
            this.ms_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_consoleInformation
            // 
            this.gb_consoleInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_consoleInformation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gb_consoleInformation.Controls.Add(this.lbl_ram);
            this.gb_consoleInformation.Controls.Add(this.label12);
            this.gb_consoleInformation.Controls.Add(this.lbl_mobo);
            this.gb_consoleInformation.Controls.Add(this.label10);
            this.gb_consoleInformation.Controls.Add(this.lbl_gpu);
            this.gb_consoleInformation.Controls.Add(this.label8);
            this.gb_consoleInformation.Controls.Add(this.lbl_cpu);
            this.gb_consoleInformation.Controls.Add(this.label6);
            this.gb_consoleInformation.Controls.Add(this.lbl_active_threads);
            this.gb_consoleInformation.Controls.Add(this.label4);
            this.gb_consoleInformation.Controls.Add(this.lbl_current_title);
            this.gb_consoleInformation.Controls.Add(this.label1);
            this.gb_consoleInformation.Location = new System.Drawing.Point(782, 393);
            this.gb_consoleInformation.Name = "gb_consoleInformation";
            this.gb_consoleInformation.Size = new System.Drawing.Size(239, 140);
            this.gb_consoleInformation.TabIndex = 0;
            this.gb_consoleInformation.TabStop = false;
            // 
            // lbl_ram
            // 
            this.lbl_ram.AutoSize = true;
            this.lbl_ram.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_ram.Location = new System.Drawing.Point(85, 76);
            this.lbl_ram.Name = "lbl_ram";
            this.lbl_ram.Size = new System.Drawing.Size(30, 13);
            this.lbl_ram.TabIndex = 11;
            this.lbl_ram.Text = "*NC*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(24, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "RAM Temp:";
            // 
            // lbl_mobo
            // 
            this.lbl_mobo.AutoSize = true;
            this.lbl_mobo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_mobo.Location = new System.Drawing.Point(85, 56);
            this.lbl_mobo.Name = "lbl_mobo";
            this.lbl_mobo.Size = new System.Drawing.Size(30, 13);
            this.lbl_mobo.TabIndex = 9;
            this.lbl_mobo.Text = "*NC*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(16, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "MOBO Temp:";
            // 
            // lbl_gpu
            // 
            this.lbl_gpu.AutoSize = true;
            this.lbl_gpu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_gpu.Location = new System.Drawing.Point(85, 116);
            this.lbl_gpu.Name = "lbl_gpu";
            this.lbl_gpu.Size = new System.Drawing.Size(30, 13);
            this.lbl_gpu.TabIndex = 7;
            this.lbl_gpu.Text = "*NC*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(25, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "GPU Temp:";
            // 
            // lbl_cpu
            // 
            this.lbl_cpu.AutoSize = true;
            this.lbl_cpu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_cpu.Location = new System.Drawing.Point(85, 96);
            this.lbl_cpu.Name = "lbl_cpu";
            this.lbl_cpu.Size = new System.Drawing.Size(30, 13);
            this.lbl_cpu.TabIndex = 5;
            this.lbl_cpu.Text = "*NC*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(26, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "CPU Temp:";
            // 
            // lbl_active_threads
            // 
            this.lbl_active_threads.AutoSize = true;
            this.lbl_active_threads.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_active_threads.Location = new System.Drawing.Point(85, 16);
            this.lbl_active_threads.Name = "lbl_active_threads";
            this.lbl_active_threads.Size = new System.Drawing.Size(30, 13);
            this.lbl_active_threads.TabIndex = 3;
            this.lbl_active_threads.Text = "*NC*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Active Threads:";
            // 
            // lbl_current_title
            // 
            this.lbl_current_title.AutoSize = true;
            this.lbl_current_title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_current_title.Location = new System.Drawing.Point(85, 36);
            this.lbl_current_title.Name = "lbl_current_title";
            this.lbl_current_title.Size = new System.Drawing.Size(30, 13);
            this.lbl_current_title.TabIndex = 1;
            this.lbl_current_title.Text = "*NC*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Title:";
            // 
            // ms_main
            // 
            this.ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_connect,
            this.tsmi_reboot,
            this.tsmi_tools});
            this.ms_main.Location = new System.Drawing.Point(0, 0);
            this.ms_main.Name = "ms_main";
            this.ms_main.Size = new System.Drawing.Size(1040, 24);
            this.ms_main.TabIndex = 1;
            this.ms_main.Text = "menuStrip1";
            // 
            // tsmi_connect
            // 
            this.tsmi_connect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_con_default,
            this.tsmi_con_add_new});
            this.tsmi_connect.Name = "tsmi_connect";
            this.tsmi_connect.Size = new System.Drawing.Size(64, 20);
            this.tsmi_connect.Text = "Connect";
            // 
            // tsmi_con_default
            // 
            this.tsmi_con_default.Name = "tsmi_con_default";
            this.tsmi_con_default.Size = new System.Drawing.Size(152, 22);
            this.tsmi_con_default.Text = "Default";
            // 
            // tsmi_con_add_new
            // 
            this.tsmi_con_add_new.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstb_con_new,
            this.tsmi_con_set_default});
            this.tsmi_con_add_new.Name = "tsmi_con_add_new";
            this.tsmi_con_add_new.Size = new System.Drawing.Size(152, 22);
            this.tsmi_con_add_new.Text = "Input IP/Name";
            // 
            // tstb_con_new
            // 
            this.tstb_con_new.Name = "tstb_con_new";
            this.tstb_con_new.Size = new System.Drawing.Size(100, 23);
            // 
            // tsmi_con_set_default
            // 
            this.tsmi_con_set_default.Name = "tsmi_con_set_default";
            this.tsmi_con_set_default.Size = new System.Drawing.Size(160, 22);
            this.tsmi_con_set_default.Text = "Set As Default";
            // 
            // tsmi_reboot
            // 
            this.tsmi_reboot.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_reboot_cold,
            this.tsmi_reboot_title,
            this.tsmi_reboot_active,
            this.tsmi_reboot_shutdown});
            this.tsmi_reboot.Name = "tsmi_reboot";
            this.tsmi_reboot.Size = new System.Drawing.Size(57, 20);
            this.tsmi_reboot.Text = "Reboot";
            // 
            // tsmi_reboot_cold
            // 
            this.tsmi_reboot_cold.Name = "tsmi_reboot_cold";
            this.tsmi_reboot_cold.Size = new System.Drawing.Size(152, 22);
            this.tsmi_reboot_cold.Text = "Cold";
            this.tsmi_reboot_cold.Click += new System.EventHandler(this.tsmi_reboot_cold_Click);
            // 
            // tsmi_reboot_title
            // 
            this.tsmi_reboot_title.Name = "tsmi_reboot_title";
            this.tsmi_reboot_title.Size = new System.Drawing.Size(152, 22);
            this.tsmi_reboot_title.Text = "Title";
            this.tsmi_reboot_title.Click += new System.EventHandler(this.tsmi_reboot_title_Click);
            // 
            // tsmi_reboot_active
            // 
            this.tsmi_reboot_active.Name = "tsmi_reboot_active";
            this.tsmi_reboot_active.Size = new System.Drawing.Size(152, 22);
            this.tsmi_reboot_active.Text = "Active Title";
            this.tsmi_reboot_active.Click += new System.EventHandler(this.tsmi_reboot_active_Click);
            // 
            // tsmi_reboot_shutdown
            // 
            this.tsmi_reboot_shutdown.Name = "tsmi_reboot_shutdown";
            this.tsmi_reboot_shutdown.Size = new System.Drawing.Size(152, 22);
            this.tsmi_reboot_shutdown.Text = "Shut Down";
            this.tsmi_reboot_shutdown.Click += new System.EventHandler(this.tsmi_reboot_shutdown_Click);
            // 
            // tsmi_tools
            // 
            this.tsmi_tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_tools_file_browser,
            this.tsmi_tools_ini_editor,
            this.tsmi_tools_swap_kv,
            this.tsmi_tools_screen_shot,
            this.tsmi_tools_debug,
            this.tsmi_tools_apps});
            this.tsmi_tools.Name = "tsmi_tools";
            this.tsmi_tools.Size = new System.Drawing.Size(48, 20);
            this.tsmi_tools.Text = "Tools";
            // 
            // tsmi_tools_file_browser
            // 
            this.tsmi_tools_file_browser.Name = "tsmi_tools_file_browser";
            this.tsmi_tools_file_browser.Size = new System.Drawing.Size(152, 22);
            this.tsmi_tools_file_browser.Text = "File Browser";
            // 
            // tsmi_tools_ini_editor
            // 
            this.tsmi_tools_ini_editor.Name = "tsmi_tools_ini_editor";
            this.tsmi_tools_ini_editor.Size = new System.Drawing.Size(152, 22);
            this.tsmi_tools_ini_editor.Text = ".ini Editor";
            this.tsmi_tools_ini_editor.Click += new System.EventHandler(this.tsmi_tools_ini_editor_Click);
            // 
            // tsmi_tools_swap_kv
            // 
            this.tsmi_tools_swap_kv.Name = "tsmi_tools_swap_kv";
            this.tsmi_tools_swap_kv.Size = new System.Drawing.Size(152, 22);
            this.tsmi_tools_swap_kv.Text = "Swap KV";
            this.tsmi_tools_swap_kv.Click += new System.EventHandler(this.tsmi_tools_swap_kv_Click);
            // 
            // tsmi_tools_screen_shot
            // 
            this.tsmi_tools_screen_shot.Name = "tsmi_tools_screen_shot";
            this.tsmi_tools_screen_shot.Size = new System.Drawing.Size(152, 22);
            this.tsmi_tools_screen_shot.Text = "Screen Shot";
            this.tsmi_tools_screen_shot.Click += new System.EventHandler(this.tsmi_tools_screen_shot_Click);
            // 
            // tsmi_tools_debug
            // 
            this.tsmi_tools_debug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_debug_console_output,
            this.tsmi_debug_dump_memory});
            this.tsmi_tools_debug.Name = "tsmi_tools_debug";
            this.tsmi_tools_debug.Size = new System.Drawing.Size(152, 22);
            this.tsmi_tools_debug.Text = "Debug";
            // 
            // tsmi_debug_console_output
            // 
            this.tsmi_debug_console_output.Name = "tsmi_debug_console_output";
            this.tsmi_debug_console_output.Size = new System.Drawing.Size(158, 22);
            this.tsmi_debug_console_output.Text = "Console Output";
            // 
            // tsmi_debug_dump_memory
            // 
            this.tsmi_debug_dump_memory.Name = "tsmi_debug_dump_memory";
            this.tsmi_debug_dump_memory.Size = new System.Drawing.Size(158, 22);
            this.tsmi_debug_dump_memory.Text = "Dump Memory";
            // 
            // tsmi_tools_apps
            // 
            this.tsmi_tools_apps.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_apps_ip_grabber,
            this.tsmi_apps_ip_spoofer,
            this.tsmi_apps_xuid_spoofer,
            this.tsmi_kv_vault,
            this.tsmi_game_info});
            this.tsmi_tools_apps.Name = "tsmi_tools_apps";
            this.tsmi_tools_apps.Size = new System.Drawing.Size(152, 22);
            this.tsmi_tools_apps.Text = "Apps";
            // 
            // tsmi_apps_ip_grabber
            // 
            this.tsmi_apps_ip_grabber.Name = "tsmi_apps_ip_grabber";
            this.tsmi_apps_ip_grabber.Size = new System.Drawing.Size(191, 22);
            this.tsmi_apps_ip_grabber.Text = "IP Grabber";
            this.tsmi_apps_ip_grabber.Click += new System.EventHandler(this.tsmi_apps_ip_grabber_Click);
            // 
            // tsmi_apps_ip_spoofer
            // 
            this.tsmi_apps_ip_spoofer.Name = "tsmi_apps_ip_spoofer";
            this.tsmi_apps_ip_spoofer.Size = new System.Drawing.Size(191, 22);
            this.tsmi_apps_ip_spoofer.Text = "IP Spoofer";
            // 
            // tsmi_apps_xuid_spoofer
            // 
            this.tsmi_apps_xuid_spoofer.Name = "tsmi_apps_xuid_spoofer";
            this.tsmi_apps_xuid_spoofer.Size = new System.Drawing.Size(191, 22);
            this.tsmi_apps_xuid_spoofer.Text = "XUID Spoofer/Grabber";
            this.tsmi_apps_xuid_spoofer.Click += new System.EventHandler(this.tsmi_apps_xuid_spoofer_Click);
            // 
            // tsmi_kv_vault
            // 
            this.tsmi_kv_vault.Name = "tsmi_kv_vault";
            this.tsmi_kv_vault.Size = new System.Drawing.Size(191, 22);
            this.tsmi_kv_vault.Text = "KV Vault";
            this.tsmi_kv_vault.Click += new System.EventHandler(this.tsmi_kv_vault_Click);
            // 
            // tsmi_game_info
            // 
            this.tsmi_game_info.Name = "tsmi_game_info";
            this.tsmi_game_info.Size = new System.Drawing.Size(191, 22);
            this.tsmi_game_info.Text = "Game Info";
            this.tsmi_game_info.Click += new System.EventHandler(this.tsmi_game_info_Click);
            // 
            // frm_main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1040, 552);
            this.Controls.Add(this.ms_main);
            this.Controls.Add(this.gb_consoleInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_main;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[#] Disconnected [#] LMAOSoft - We\'re all soft.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_main_FormClosing);
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frm_main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frm_main_DragEnter);
            this.gb_consoleInformation.ResumeLayout(false);
            this.gb_consoleInformation.PerformLayout();
            this.ms_main.ResumeLayout(false);
            this.ms_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_consoleInformation;
        private System.Windows.Forms.Label lbl_current_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_mobo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_gpu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_cpu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_active_threads;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_ram;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.ToolStripMenuItem tsmi_connect;
        private System.Windows.Forms.ToolStripMenuItem tsmi_con_default;
        private System.Windows.Forms.ToolStripMenuItem tsmi_con_add_new;
        private System.Windows.Forms.ToolStripTextBox tstb_con_new;
        private System.Windows.Forms.ToolStripMenuItem tsmi_con_set_default;
        private System.Windows.Forms.ToolStripMenuItem tsmi_reboot;
        private System.Windows.Forms.ToolStripMenuItem tsmi_reboot_cold;
        private System.Windows.Forms.ToolStripMenuItem tsmi_reboot_title;
        private System.Windows.Forms.ToolStripMenuItem tsmi_reboot_active;
        private System.Windows.Forms.ToolStripMenuItem tsmi_reboot_shutdown;
        private System.Windows.Forms.ToolStripMenuItem tsmi_tools;
        private System.Windows.Forms.ToolStripMenuItem tsmi_tools_file_browser;
        private System.Windows.Forms.ToolStripMenuItem tsmi_tools_ini_editor;
        private System.Windows.Forms.ToolStripMenuItem tsmi_tools_swap_kv;
        private System.Windows.Forms.ToolStripMenuItem tsmi_tools_screen_shot;
        private System.Windows.Forms.ToolStripMenuItem tsmi_tools_debug;
        private System.Windows.Forms.ToolStripMenuItem tsmi_debug_console_output;
        private System.Windows.Forms.ToolStripMenuItem tsmi_debug_dump_memory;
        private System.Windows.Forms.ToolStripMenuItem tsmi_tools_apps;
        private System.Windows.Forms.ToolStripMenuItem tsmi_apps_ip_grabber;
        private System.Windows.Forms.ToolStripMenuItem tsmi_apps_ip_spoofer;
        private System.Windows.Forms.ToolStripMenuItem tsmi_apps_xuid_spoofer;
        private System.Windows.Forms.ToolStripMenuItem tsmi_kv_vault;
        private System.Windows.Forms.ToolStripMenuItem tsmi_game_info;
    }
}

