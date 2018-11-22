using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using LMAOSoft.Misc;
using LMAOSoft.Inc.Forms.Tools.Sub_Form;
using System.Text.RegularExpressions;

namespace LMAOSoft.Inc.Forms.Tools
{
    public partial class frm_edit_ini : Form
    {
        public string chosen_drive = "";
        public frm_edit_ini()
        {
            InitializeComponent();
        }

        private void tsmi_load_console_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("Recieved"))
                Directory.CreateDirectory("Recieved");

            if (Vars.isConnected) {
                if (File.Exists(Folders.Recieved + "\\" + FileNames.launchINI))
                    File.Delete(Folders.Recieved + "\\" + FileNames.launchINI);
                List<string> FoundDrives = new List<string>();
                if (Xbox.GetDrives().Length > 1) {
                    foreach (string drive in Xbox.GetDrives()) {
                        try {
                            Vars.xbCon.ReceiveFile(Folders.Recieved + "\\" + FileNames.launchINI, drive + ":\\" + FileNames.launchINI);
                            FoundDrives.Add(drive);
                        } catch { continue; }
                    }
                }

                if (FoundDrives.Count > 1) {
                    File.Delete(Folders.Recieved + "\\" + FileNames.launchINI);
                    frm_sub_edit_ini sub_ini = new frm_sub_edit_ini(FoundDrives.ToArray());
                    if (sub_ini.ShowDialog() == DialogResult.OK) {
                        try {
                            if (Vars.isConnected) {
                                Vars.xbCon.ReceiveFile(Folders.Recieved + "\\" + FileNames.launchINI, this.chosen_drive + ":\\" + FileNames.launchINI);
                                using (StreamReader sr = new StreamReader(Folders.Recieved + "\\" + FileNames.launchINI)) {
                                    rtb_ini_editor.Text = sr.ReadToEnd();
                                }
                            } else MessageBox.Show("Not connected to console.");
                        } catch { MessageBox.Show("There was an error recieving file! Please try again!"); }
                    }
                } else {
                    File.Delete(Folders.Recieved + "\\" + FileNames.launchINI);
                    this.chosen_drive = FoundDrives[0];
                    try {
                        if (Vars.isConnected) {
                            Vars.xbCon.ReceiveFile(Folders.Recieved + "\\" + FileNames.launchINI, this.chosen_drive + ":\\" + FileNames.launchINI);
                            using (StreamReader sr = new StreamReader(Folders.Recieved + "\\" + FileNames.launchINI)) {
                                rtb_ini_editor.Text = sr.ReadToEnd();
                            }
                        } else MessageBox.Show("Not connected to console.");
                    } catch { MessageBox.Show("There was an error recieving file! Please try again!"); }
                }
            } else { MessageBox.Show("Connect to your console!"); }
        }

        private void tsmi_file_remove_comments_Click(object sender, EventArgs e)
        {
            if (rtb_ini_editor.Text.Count() > 0) {
                Regex rex = new Regex(@"^\s+$[\r\n]*");
                List<string> decommented_ini = new List<string>();
                string[] current_ini = rtb_ini_editor.Text.Split('\n');
                foreach (string line in current_ini) {
                    if (line.StartsWith(";") || line == "\n\r" || rex.IsMatch(line)) continue;
                    decommented_ini.Add(line);
                } rtb_ini_editor.Text = "";

                for (int i = 0; i < decommented_ini.Count; i++) {
                    rtb_ini_editor.Text = rtb_ini_editor.Text + decommented_ini[i] + "\n";
                }
            }
        }

        private void tsmi_save_console_Click(object sender, EventArgs e)
        {
            if (rtb_ini_editor.Text.Count() > 0) {
                try {
                    using (StreamWriter sw = new StreamWriter(Folders.Recieved + "\\" + FileNames.launchINI))
                        sw.Write(rtb_ini_editor.Text);
                    Vars.xbCon.SendFile(Folders.Recieved + "\\" + FileNames.launchINI, this.chosen_drive + ":\\" + FileNames.launchINI);
                    Functions.ShowBaloonTip("File Uploaded!", "Sent your launch.ini to " + Vars.xbMgr.DefaultConsole + "!", ToolTipIcon.Info);
                } catch { Functions.ShowBaloonTip("Oh no!", "Failed to send the launch.ini to " + Vars.xbMgr.DefaultConsole + ".", ToolTipIcon.Info); }
            }
        }
    }
}
