using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

using LMAOSoft.Misc;
using LMAOSoft.Inc.Forms.Tools.Sub_Form;

namespace LMAOSoft.Inc.Forms.Tools
{
    public partial class frm_screen_shot : Form
    {
        private string ImageName = "";
        public frm_screen_shot()
        {
            InitializeComponent();
        }

        private void tsmi_take_picture_Click(object sender, EventArgs e)
        {
            if (Vars.isConnected) {
                ImageName = String.Format("{0}-picture {1}", Vars.xbMgr.DefaultConsole, DateTime.Now.ToString("M-d-yyyy h-mm-sstt"));

                if (!Directory.Exists(Folders.Temp))
                    Directory.CreateDirectory(Folders.Temp);
                if (!Directory.Exists(Folders.Pictures))
                    Directory.CreateDirectory(Folders.Pictures);

                try {
                    Vars.xbCon.ScreenShot(Folders.Temp + "\\" + ImageName + ".bmp");
                    using (var fStream = new FileStream(Folders.Temp + "\\" + ImageName + ".bmp", FileMode.Open)) {
                        new Bitmap(fStream).Save(Folders.Pictures + "\\" + ImageName + ".png", ImageFormat.Png);
                    } File.Delete(Folders.Temp + "\\" + ImageName + ".bmp");
                } catch { return; }

                pb_image.Image = Image.FromFile(Folders.Pictures + "\\" + ImageName + ".png");
            }
        }

        private void tsmi_upload_Click(object sender, EventArgs e)
        {
            if (ImageName != "") {
                if (imgur.UploadImage(Folders.Pictures + "\\" + ImageName + ".png")) {
                    System.Media.SystemSounds.Hand.Play();
                    Clipboard.SetText(imgur.Link);
                    if (!Directory.Exists(Folders.Logs))
                        Directory.CreateDirectory(Folders.Logs);
                    using (StreamWriter sw = new StreamWriter(Folders.Logs + "\\Screen Shots.txt", true)) {
                        sw.WriteLine("=============== File: {0} ===============\nImgur Public Link: {1}\nImgur Delete Link: {2}\n",
                            Folders.Pictures + "\\" + ImageName + ".png",
                            imgur.Link,
                            "https://imgur.com/delete/" + imgur.delHash
                        );
                    }
                    Functions.ShowBaloonTip("Uploaded To Imgur!", "Link copied to clipboard!", ToolTipIcon.Info);
                }
            }
        }

        private void tsmi_manage_Click(object sender, EventArgs e)
        {
            frm_sub_screen_shot ManageImages = new frm_sub_screen_shot();
            ManageImages.MdiParent = this.MdiParent;
            ManageImages.Show();
        }
    }
}
