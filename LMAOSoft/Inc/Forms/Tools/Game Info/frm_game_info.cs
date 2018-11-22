using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;

using Endian;
using X360.STFS;
using X360.Other;
using FormEssentials;

using LMAOSoft.Misc;

namespace LMAOSoft.Inc.Forms.Tools
{
    public partial class frm_game_info : Form
    {
        private STFSPackage STFSP;
        private LogRecord Log = new LogRecord();
        private string FileLocation = "";

        public frm_game_info(string FileLocation)
        {
            this.FileLocation = FileLocation;
            InitializeComponent();
        }

        private void frm_game_info_Load(object sender, EventArgs e)
        {
            if (File.Exists(this.FileLocation) && this.FileLocation != "") {
                this.GatherInformation(this.FileLocation);
            } else {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Find STFS File";
                ofd.Filter = "All Files *.*|*.*";
                if (ofd.ShowDialog() == DialogResult.OK) {
                    if (File.Exists(ofd.FileName)) {
                        this.FileLocation = ofd.FileName;
                        this.GatherInformation(ofd.FileName);
                    }
                }
            }
        }

        private void GatherInformation(string Location)
        {
            try {
                this.STFSP = new STFSPackage(Location, this.Log);
                if (this.STFSP.ParseSuccess) {
                    try {
                        pb_content.Image = this.STFSP.Header.ContentImage;
                        pb_package.Image = this.STFSP.Header.PackageImage;
                    } catch { }

                    tb_display.Text = this.STFSP.Header.Title_Display;
                    tb_titleName.Text = this.STFSP.Header.Title_Package;
                    tb_deviceID.Text = Conversion.BytesToHexString(this.STFSP.Header.DeviceID);
                    tb_titleID.Text = this.STFSP.Header.TitleID.ToString("X2").ToUpper();
                    this.STFSP.CloseIO();
                    // Now we'll do our own shit to get the location of where this package goes.
                    List<byte> fileBytes = FileEx.ReadBytes(Location, 0, 0x9725).ToList();
                    string[] accepted = { "LIVE", "PIRS", "CON " };
                    string fileType = Encoding.UTF8.GetString(fileBytes.GetRange(0, 0x4).ToArray());
                    if (accepted.Contains(fileType)) {
                        tb_consoleID.Text = Conversion.BytesToHexString(fileBytes.GetRange(0x36C, 0x4).ToArray());
                        tb_profileID.Text = Conversion.BytesToHexString(fileBytes.GetRange(0x371, 0x4).ToArray());
                        string SubFolder = Conversion.BytesToHexString(fileBytes.GetRange(0x344, 0x4).ToArray());
                        string TitleFolder = Conversion.BytesToHexString(fileBytes.GetRange(0x360, 0x4).ToArray());
                        string ContentRoot = this.STFSP.Header.ThisType != PackageType.Profile ? Conversion.BytesToHexString(fileBytes.GetRange(0x364, 0x8).ToArray()) : this.STFSP.Header.Title_Display;
                        string Revision = Convert.ToInt32(fileBytes.GetRange(0x9724, 0x1).ToArray()[0]).ToString();
                        lbl_rootFolder.Text = ContentRoot;
                        lbl_titleFolder.Text = TitleFolder;
                        lbl_subFolder.Text = SubFolder;
                        tb_fullDirectory.Text = String.Format("HDD:\\Content\\{0}\\{1}\\{2}", ContentRoot, TitleFolder, SubFolder);
                        this.Text = String.Format("Game Info - {0}: TU {1}", (tb_titleName.Text != "" ? tb_titleName.Text : Xbox.HexTitleToName(Convert.ToUInt32(tb_titleID.Text, 16))), Revision);
                    } else { if (MessageBox.Show(Location + "\r\n\r\nInvalid file format! " + fileType, "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) return; }
                }
            } catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Error Loading File", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tsmi_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmi_send_Click(object sender, EventArgs e)
        {
            if (Vars.isConnected) {
                try {
                    new Thread(new ThreadStart(() => {
                        string Buffer = "hdd:";
                        foreach (string Folder in tb_fullDirectory.Text.Replace("HDD:\\", "").Split('\\')) {
                            try {
                                Buffer += "\\" + Folder;
                                Vars.xbCon.MakeDirectory(Buffer);
                            } catch { }
                        }

                        try {
                            Vars.xbCon.SendFile(this.FileLocation, String.Format("{0}\\{1}", tb_fullDirectory.Text, this.FileLocation.Split('\\').Last()));
                        } catch (Exception ex) { MessageBox.Show(String.Format("Error: {0}", Enum.GetName(typeof(XBDMCodes), ex.HResult)), "0x" + ex.HResult.ToString("x2")); }
                        Invoke(new MethodInvoker(() => { MessageBox.Show(String.Format("\"{0}\" Has been sent to the console successfully!", tb_display.Text), "W00t!"); }));
                    })).Start();
                } catch (Exception ex) { MessageBox.Show(String.Format("Failed to send file to console! Error: {0}\n\nHex Error: 0x{1}", Enum.GetName(typeof(XBDMCodes), ex.HResult), ex.HResult.ToString("X2"))); }
            } else MessageBox.Show("You're currently not connected to your console!");
        }
    }
}
