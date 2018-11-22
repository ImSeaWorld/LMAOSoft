using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using XDevkit;
using JRPC_Client;
using LMAOSoft.Misc;
using FormEssentials;
using System.Threading;
using System.Text.RegularExpressions;

namespace LMAOSoft.Inc.Forms.Apps
{
    public partial class frm_ip_grabber : Form
    {
        private Regex reg;

        public frm_ip_grabber()
        {
            InitializeComponent();
        }

        private void btn_grab_Click(object sender, EventArgs e)
        {
            lv_info.Items.Clear();
        }

        private uint InfoAddress(int client)
        {
            switch ((uint)Vars.xbCon.XamGetCurrentTitleId()) {
                case (uint)Title.GTA_V: return (uint)(0xC89A2AF0 + (client * 0x78));
                case (uint)Title.COD4: return (uint)(0x8243D700 + (client * 0xB8));
                case (uint)Title.MW2: return (uint)(0x8268EEC2 + (client * 0xC0));
                case (uint)Title.BO1: return (uint)(0x829F8450 + (client * 0x200));
                case (uint)Title.MW3: return (uint)(0x82720EEC + (client * 0x158));
                case (uint)Title.BO2: return (uint)(0x82CAC3A0 + (client * 0x148));
                case (uint)Title.GHOSTS: return (uint)(0x82BBD634 + (client * 0x1C0));
                case (uint)Title.AW: return (uint)(0x82B7E640 + (client * 0x350));
                case (uint)Title.BO3: return (uint)(0xC49E11C8 + (client * 0x108));
            } return 0xE;
        }

        private string GetIP(uint Address)
        {
            byte[] IP = null;
            try {
                switch ((uint)Vars.xbCon.XamGetCurrentTitleId()) {
                    case (uint)Title.GTA_V: IP = Vars.xbCon.GetMemory(Address + 0x4, 0x4); break;
                    case (uint)Title.COD4: IP = Vars.xbCon.GetMemory(Address + 0x58, 0x4); break;
                    case (uint)Title.MW2: IP = Vars.xbCon.GetMemory(Address + 0x42, 0x4); break;
                    case (uint)Title.BO1: IP = Vars.xbCon.GetMemory(Address + 0x60, 0x4); break;
                    case (uint)Title.MW3: IP = Vars.xbCon.GetMemory(Address + 0xB8, 0x4); break;
                    case (uint)Title.BO2: IP = Vars.xbCon.GetMemory(Address + 0x7C, 0x4); break;
                    case (uint)Title.GHOSTS: IP = Vars.xbCon.GetMemory(Address + 0xE8, 0x4); break;
                    case (uint)Title.AW: IP = Vars.xbCon.GetMemory(Address + 0x29C, 0x4); break;
                    case (uint)Title.BO3: IP = Vars.xbCon.GetMemory(Address + 0xE9, 0x4).Reverse().ToArray(); break;
                    default: return "0.0.0.0";
                } return String.Format("{0}.{1}.{2}.{3}", IP[0], IP[1], IP[2], IP[3]);
            } catch { return "*ERROR*"; }
        }

        private string GetGamertag(uint Address)
        {
            try {
                switch ((uint)Vars.xbCon.XamGetCurrentTitleId()) {
                    case (uint)Title.GTA_V: return Encoding.ASCII.GetString(Vars.xbCon.GetMemory(Address + 0x4C, 0xF)).Replace("\0", "");
                    case (uint)Title.COD4: return Encoding.ASCII.GetString(Vars.xbCon.GetMemory(Address + 0x8, 0xF)).Replace("\0", "");
                    case (uint)Title.MW2: return Encoding.ASCII.GetString(Vars.xbCon.GetMemory(Address, 0xF)).Replace("\0", "");
                    case (uint)Title.BO1: return Encoding.ASCII.GetString(Vars.xbCon.GetMemory(Address + 0x8, 0xF)).Replace("\0", "");
                    case (uint)Title.MW3: return Encoding.ASCII.GetString(Vars.xbCon.GetMemory(Address, 0xF)).Replace("\0", "");
                    case (uint)Title.BO2: return Encoding.ASCII.GetString(Vars.xbCon.GetMemory(Address + 0x8, 0xF)).Replace("\0", "");
                    case (uint)Title.GHOSTS: return Encoding.ASCII.GetString(Vars.xbCon.GetMemory(Address, 0xF)).Replace("\0", "");
                    case (uint)Title.AW: return Encoding.ASCII.GetString(Vars.xbCon.GetMemory(Address, 0xF)).Replace("\0", "");
                    case (uint)Title.BO3: return Encoding.ASCII.GetString(Vars.xbCon.GetMemory(Address + 0x9, 0xF)).Replace("\0", "");
                } return "*N/A*";
            } catch { return "*ERROR*"; }
        }

        private void GetInfo()
        {
            if (Vars.isConnected) {
                new Thread(new ThreadStart(delegate {
                    reg = new Regex("^[0-9A-Za-z ,.']+$");
                    int MaxClient = (Vars.xbCon.XamGetCurrentTitleId() == (uint)Title.GTA_V ? 29 : 18);
                    for (int i = 0; i < MaxClient; i++) {
                        string Gamertag = GetGamertag(InfoAddress(i)), IP = GetIP(InfoAddress(i));
                        if (Gamertag == "*ERROR*" || Gamertag == "*N/A*" || Gamertag == "" || reg.IsMatch(Gamertag)) continue;
                        if (IP == "*ERROR*") continue;
                        Invoke(new MethodInvoker(delegate { FormE.ListViews.addToListView(lv_info, Gamertag, IP); }));
                    }
                })).Start();
            }
        }

        private void tsmi_copy_gamertag_Click(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(delegate { Clipboard.SetText(lv_info.SelectedItems[0].SubItems[0].Text); }));
        }

        private void tsmi_copy_ip_Click(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(delegate { Clipboard.SetText(lv_info.SelectedItems[0].SubItems[1].Text); }));
        }

        private void tsmi_copy_both_Click(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(delegate { Clipboard.SetText(String.Format("{0}:{1}", lv_info.SelectedItems[0].SubItems[0].Text, lv_info.SelectedItems[0].SubItems[1].Text)); }));
        }

        private void tsmi_get_xuid_Click(object sender, EventArgs e)
        {
            frm_main main = new frm_main();
            frm_xuid xuid = new frm_xuid(lv_info.SelectedItems[0].SubItems[0].Text);
            xuid.MdiParent = main.ParentForm;
            xuid.Show();
        }
    }
}
