using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

using Endian;
using X360.STFS;
using X360.Other;
using LMAOSoft.Misc;
using FormEssentials;

namespace LMAOSoft.Inc.Forms.Tools.Game_Info
{
    public partial class frm_game_info_multiple : Form
    {
        private bool Finished = false;
        private int Errors = 0, Successes = 0;
        private string[] Files;
        private LogRecord Logs = new LogRecord();
        private List<STFSInfo> Info = new List<STFSInfo>();
        private STFSPackage STFSP;

        private struct STFSInfo
        {
            public string      Local,
                TitleName,     TitleID,
                ProfileID,     Display,
                DeviceID,      ConsoleID,
                Revision,      Root,
                Title,         Sub,
                FullDirectory, Hash;

            public Image Package, Content;
            public bool Error, HasImage;
        }

        public frm_game_info_multiple(params string[] Files)
        {
            this.Files = Files;
            InitializeComponent();
        }

        private void frm_game_info_multiple_Load(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(delegate {
                for (int i = 0; i < Files.Count(); i++) {
                    Image Content = null, Package = null;
                    bool Error = false, HasImage = true;
                    string Display = "", Title = "", DeviceID = "", TitleID = "", ConsoleID = "", ProfileID = "", SubFolder = "", TitleFolder = "", ContentRoot = "", FullDirectory = "", Hash = "", Revision = "";

                    STFSP = new STFSPackage(this.Files[i], Logs);
                    if (STFSP.ParseSuccess) {
                        try {
                            try {
                                Content = this.STFSP.Header.ContentImage;
                                Package = this.STFSP.Header.PackageImage;
                            } catch { HasImage = false; }

                            Display = this.STFSP.Header.Title_Display;
                            Title = this.STFSP.Header.Title_Package;
                            DeviceID = Conversion.BytesToHexString(this.STFSP.Header.DeviceID);
                            TitleID = this.STFSP.Header.TitleID.ToString("X2").ToUpper();
                            this.STFSP.CloseIO();

                            List<byte> fileBytes = FileEx.ReadBytes(this.Files[i], 0, 0x9725/*0x450*/).ToList();
                            string[] accepted = { "LIVE", "PIRS", "CON " };
                            string fileType = Encoding.UTF8.GetString(fileBytes.GetRange(0, 0x4).ToArray());
                            if (accepted.Contains(fileType)) {
                                ConsoleID = Conversion.BytesToHexString(fileBytes.GetRange(0x36C, 0x4).ToArray());
                                ProfileID = Conversion.BytesToHexString(fileBytes.GetRange(0x371, 0x4).ToArray());
                                SubFolder = Conversion.BytesToHexString(fileBytes.GetRange(0x344, 0x4).ToArray());
                                TitleFolder = Conversion.BytesToHexString(fileBytes.GetRange(0x360, 0x4).ToArray());
                                Revision = Convert.ToInt32(fileBytes.GetRange(0x9724, 0x1).ToArray()[0]).ToString();
                                ContentRoot = this.STFSP.Header.ThisType != PackageType.Profile ? Conversion.BytesToHexString(fileBytes.GetRange(0x364, 0x8).ToArray()) : this.STFSP.Header.Title_Display;
                                FullDirectory = String.Format("HDD:\\Content\\{0}\\{1}\\{2}", ContentRoot, TitleFolder, SubFolder);
                                Hash = Hashing.MD5(fileBytes.ToArray()).Substring(0, 12).ToUpper();
                            }
                        } catch { Invoke(new MethodInvoker(() => { Error = true; this.Text = String.Format("Game Info - {0}/{1} | Errors: {2}", this.Successes, this.Files.Count(), this.Errors++); })); }
                        Info.Add(new STFSInfo { 
                            Display = Display, Title = TitleFolder, DeviceID = DeviceID, TitleID = TitleID, ConsoleID = ConsoleID, ProfileID = ProfileID, Sub = SubFolder, TitleName = Title,
                            Content = Content, FullDirectory = FullDirectory, Package = Package, Root = ContentRoot, Local = this.Files[i], Error = Error, Hash = Hash, HasImage = HasImage, Revision = Revision
                        });
                        Invoke(new MethodInvoker(() => { 
                            this.Text = String.Format("Game Info - {0}/{1}{2}{3}", this.Successes++, this.Files.Count(), (Error ? " | Errors: " : ""), (Error ? this.Errors.ToString() : ""));
                            if (!Error)
                                FormE.ListViews.addToListView(lv_main, TitleID, (Title == "" ? Xbox.HexTitleToName(Convert.ToUInt32(TitleID, 16)) : Title), "Loaded", Hash, Revision);
                        }));
                    } else { this.Errors++; }
                } Invoke(new MethodInvoker(() => { this.Text = "Game Info - Finished Loading Files"; this.Finished = true; Info.ForEach(s => Console.WriteLine(s.ToString())); }));
            })).Start();
        }

        private void lv_main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                if (lv_main.SelectedItems.Count > 0)
                    cms_game_info.Show(Cursor.Position);
        }

        private void lv_main_DoubleClick(object sender, EventArgs e)
        {
            if (lv_main.SelectedItems.Count > 0) {
                tb_titleName.Enabled = true;
                tb_titleID.Enabled = true;
                tb_profileID.Enabled = true;
                tb_display.Enabled = true;
                tb_deviceID.Enabled = true;
                tb_consoleID.Enabled = true;

                STFSInfo SelectedInfo = Info.Find(x => x.Hash == lv_main.SelectedItems[0].SubItems[3].Text);
                pb_content.Image = (SelectedInfo.HasImage ? SelectedInfo.Content : Properties.Resources.empty);
                pb_package.Image = (SelectedInfo.HasImage ? SelectedInfo.Package : Properties.Resources.empty);
                tb_display.Text = SelectedInfo.Display;
                tb_titleName.Text = SelectedInfo.TitleName;
                tb_deviceID.Text = SelectedInfo.DeviceID;
                tb_profileID.Text = SelectedInfo.ProfileID;
                tb_consoleID.Text = SelectedInfo.ConsoleID;
                tb_titleID.Text = SelectedInfo.TitleID;
                lbl_rootFolder.Text = SelectedInfo.Root;
                lbl_subFolder.Text = SelectedInfo.Sub;
                lbl_titleFolder.Text = SelectedInfo.Title;
                tb_fullDirectory.Text = SelectedInfo.FullDirectory;
            }
        }

        private void tsmi_select_all_Click(object sender, EventArgs e)
        {
            if (lv_main.Items.Count > 1) {
                foreach (ListViewItem Item in lv_main.Items) {
                    Item.Selected = true;
                }
            }
        }

        private void tsmi_remove_Click(object sender, EventArgs e)
        {
            if (lv_main.SelectedItems.Count > 0) {
                Info.RemoveAt(Info.FindIndex(x => x.Hash == lv_main.SelectedItems[0].SubItems[3].Text));
                lv_main.SelectedItems[0].Remove();
            }
        }

        private void tsmi_remove_all_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv_main.Items) {
                Info.RemoveAt(Info.FindIndex(x => x.Hash == item.SubItems[3].Text));
                item.Remove();
            }
        }

        private void tsmi_remove_duplicates_Click(object sender, EventArgs e)
        {
            // Check the TitleID and check the TU to ensure we have the latest in the list.
            MessageBox.Show("Fuck... I haven't added that yet.");
        }

        private void tsmi_send_selected_Click(object sender, EventArgs e)
        {
            if (Vars.isConnected) {

            } else MessageBox.Show("You're currently not connected to your console!");
        }
    }
}
