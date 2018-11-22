using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using XDevkit;
using X360.STFS;
using X360.Other;
using JRPC_Client;
using FormEssentials;

using LMAOSoft.Misc;
using LMAOSoft.Inc.Forms.Apps;
using LMAOSoft.Inc.Forms.Tools;
using LMAOSoft.Inc.Forms.Tools.Game_Info;

namespace LMAOSoft
{
    public partial class frm_main : Form
    {
        public void Status(string status)
        {
            this.Text = String.Format("[#] {0} [#] LMAOSoft - We're all soft.", status);
        }

        public void Current(double GPU, double CPU, double RAM, double MOBO, string title, string Threads)
        {
            lbl_active_threads.Text = Threads;
            lbl_current_title.Text = title;
            lbl_mobo.Text = String.Format("{0}°F - {1}°C", (((9.0 / 5.0) * MOBO) + 32), MOBO);
            lbl_ram.Text = String.Format("{0}°F - {1}°C", (((9.0 / 5.0) * RAM) + 32), RAM);
            lbl_cpu.Text = String.Format("{0}°F - {1}°C", (((9.0 / 5.0) * CPU) + 32), CPU);
            lbl_gpu.Text = String.Format("{0}°F - {1}°C", (((9.0 / 5.0) * GPU) + 32), GPU);
        }

        public Control ReturnGroupbox()
        {
            return gb_consoleInformation;
        }

        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            MdiClient mdiClient;
            foreach (Control ctrl in this.Controls) {
                try {
                    mdiClient = (MdiClient)ctrl;
                    mdiClient.BackColor = this.BackColor;
                } catch { }
            }

            if (Directory.Exists("Titles")) {
                if (File.Exists("Titles\\Titles.txt")) {
                    Xbox.Titles_s = new List<Xbox.Titles>();
                    foreach (string line in File.ReadAllLines("Titles\\Titles.txt")) {
                        if (line.StartsWith("//")) continue;
                        Xbox.Titles_s.Add(new Xbox.Titles { 
                            title = BitConverter.ToUInt32(Conversion.HexStringToBytes(line.Split('=')[0]).Reverse().ToArray(), 0), 
                            name = line.Split('=')[1]
                        });
                    }
                }
            } else Directory.CreateDirectory("Titles");

            tsmi_con_default.Text = String.Format("Default [{0}]", Vars.xbMgr.DefaultConsole);
            if (Settings.bAutoConnect) {
                this.Status("Auto-Connecting...");
                Xbox.ThreadedConnection().Start();
            }
        }

        private void frm_main_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = ((string[])e.Data.GetData(DataFormats.FileDrop));
            string droppedFile = droppedFiles[0];
            switch (VariousFunctions.ReadFileType(droppedFile)) {
                case XboxFileType.Music: break;
                case XboxFileType.STFS: {
                    if (droppedFiles.Count() > 1) {
                        List<string> Accepted = new List<string>();
                        for (int i = 0; i < droppedFiles.Count(); i++) {
                            if (VariousFunctions.ReadFileType(droppedFiles[i]) == XboxFileType.STFS)
                                Accepted.Add(droppedFiles[i]);
                        }

                        if (Accepted.ToArray().Count() > 1) {
                            frm_game_info_multiple gim = new frm_game_info_multiple(Accepted.ToArray());
                            gim.MdiParent = this;
                            gim.Show();
                        } else if (Accepted.ToArray().Count() == 1) {
                            frm_game_info gi = new frm_game_info(Accepted.ToArray()[0]);
                            gi.MdiParent = this;
                            gi.Show();
                        }
                    } else if (droppedFiles.Count() == 1) {
                        frm_game_info gi = new frm_game_info(droppedFile);
                        gi.MdiParent = this;
                        gi.Show();
                    } break; 
                }
                case XboxFileType.SVOD: break;
                case XboxFileType.FATX: break;
                case XboxFileType.GPD: break;
                case XboxFileType.GDF: break;
                default: MessageBox.Show("Unknown file type!"); break;
            }
        }

        private void frm_main_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void tsmi_reboot_cold_Click(object sender, EventArgs e)
        {
            Xbox.Reboot(XDevkit.XboxRebootFlags.Cold);
        }

        private void tsmi_reboot_title_Click(object sender, EventArgs e)
        {
            Xbox.Reboot(XDevkit.XboxRebootFlags.Title);
        }

        private void tsmi_reboot_active_Click(object sender, EventArgs e)
        {
            Xbox.Reboot(XDevkit.XboxRebootFlags.Warm);
        }

        private void tsmi_reboot_shutdown_Click(object sender, EventArgs e)
        {
            Vars.xbCon.ShutDownConsole();
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions.Notify.Visible = false;
            Application.Exit();
            Environment.Exit(1);
        }

        private void tsmi_apps_ip_grabber_Click(object sender, EventArgs e)
        {
            frm_ip_grabber grabber = new frm_ip_grabber();
            grabber.MdiParent = this;
            grabber.Show();
        }

        private void tsmi_apps_xuid_spoofer_Click(object sender, EventArgs e)
        {
            frm_xuid xuid = new frm_xuid();
            xuid.MdiParent = this;
            xuid.Show();
        }

        private void tsmi_tools_ini_editor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to open the EZ INI editor? If no, it will open the raw editor.", "So..", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
                frm_edit_ini_ez ez_ini = new frm_edit_ini_ez();
                ez_ini.MdiParent = this;
                ez_ini.Show();
            } else {
                frm_edit_ini ini = new frm_edit_ini();
                ini.MdiParent = this;
                ini.Show();
            }
        }

        private void tsmi_tools_screen_shot_Click(object sender, EventArgs e)
        {
            frm_screen_shot screeny = new frm_screen_shot();
            screeny.MdiParent = this;
            screeny.Show();
        }

        private void tsmi_tools_swap_kv_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to check your vault? If not we'll open a prompt for you to search.", "So..", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
                frm_kv_vault kv_vault = new frm_kv_vault();
                kv_vault.MdiParent = this;
                kv_vault.Show();
            } else {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Select a KV...";
                ofd.Filter = "Bin File *.bin|*.bin|All Types *.*|*.*";

                if (ofd.ShowDialog() == DialogResult.OK) {
                    // Check signatures to ensure it's a valid KV
                    // If it's a valid KV, prompt with replace and restart (yes/no)
                }
            }
        }

        private void tsmi_kv_vault_Click(object sender, EventArgs e)
        {
            frm_kv_vault kv_vault = new frm_kv_vault();
            kv_vault.MdiParent = this;
            kv_vault.Show();
        }

        private void tsmi_game_info_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Game Info has the ability to send/view 1 or more update files or profile files. If you'd like to open more than one, be sure you have all of the ones you'd like to choose in one folder.", "Game Info - Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Find STFS File";
                ofd.Filter = "All Files *.*|*.*";
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK) {

                    List<string> AcceptedFiles = new List<string>();

                    for (int i = 0; i < ofd.FileNames.Count(); i++) {
                        if (VariousFunctions.ReadFileType(ofd.FileNames[i]) == XboxFileType.STFS)
                            AcceptedFiles.Add(ofd.FileNames[i]);
                    }

                    if (AcceptedFiles.Count > 1) {
                        frm_game_info_multiple gim = new frm_game_info_multiple(AcceptedFiles.ToArray());
                        gim.MdiParent = this;
                        gim.Show();
                    } else if (AcceptedFiles.Count == 1) {
                        frm_game_info gi = new frm_game_info(AcceptedFiles.ToArray()[0]);
                        gi.MdiParent = this;
                        gi.Show();
                    } else { MessageBox.Show("No files were accepted!\n\nPlease ensure you have accepted STFS files!", "Oh noes!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }
    }
}
