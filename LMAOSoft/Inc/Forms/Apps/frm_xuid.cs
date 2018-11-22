using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using JRPC_Client;
using LMAOSoft.Misc;
using FormEssentials;

namespace LMAOSoft.Inc.Forms.Apps
{
    public partial class frm_xuid : Form
    {
        private string input_gt = "";
        private uint XUserFindUserAddress = 0x81829158/*17502 0x81829018*/, XamFreeMemory = 0x81AA2000;

        private enum XUIDAddr : uint {
            COD4 = 0x84C24BBC,
            WAW = 0x852336B5,
            MW2 = 0x838BA824,
            BO1 = 0x841987D5,
            MW3 = 0x839691AC,
            BO2 = 0x841E1B30,
            GHOSTS = 0x83F0A35C,
            AW = 0x84493A94
        };

        public frm_xuid(string Gamertag = "")
        {
            InitializeComponent();

            if (Gamertag != "")
                this.input_gt = Gamertag;
        }

        private string GetXUID(string gt)
        {
            if (Vars.isConnected) {
                if (Vars.xbCon.Call<uint>(XUserFindUserAddress, new object[] { 0x9000006F93463L, 0, gt, 0x18, XamFreeMemory, 0 }) == 0)
                    return BitConverter.ToString(Vars.xbCon.GetMemory(XamFreeMemory, 8)).Replace("-", "");
            } return "ERR";
        }

        private uint xuidAddress()
        {
            try {
                if (Vars.isConnected) {
                    switch (Vars.xbCon.XamGetCurrentTitleId()) {
                        case (uint)Title.COD4: return (uint)XUIDAddr.COD4;
                        case (uint)Title.MW2: return (uint)XUIDAddr.MW2;
                        case (uint)Title.BO1: return (uint)XUIDAddr.BO1;
                        case (uint)Title.MW3: return (uint)XUIDAddr.MW3;
                        case (uint)Title.BO2: return (uint)XUIDAddr.BO2;
                        case (uint)Title.GHOSTS: return (uint)XUIDAddr.GHOSTS;
                        case (uint)Title.AW: return (uint)XUIDAddr.AW;
                        default: return 0xDE;
                    }
                } else return 0xDEAD;
            } catch { return 0xEE; }
        }

        private byte[] ReverseBytes(byte[] input) { return input.Reverse().ToArray(); }
        private byte[] ReverseBytes(string input) { return Encoding.UTF8.GetBytes(input).Reverse().ToArray(); }

        private bool setXUID(uint address, string GT, string XUID)
        {
            if (address == 0xEE || address == 0xDE) {
                MessageBox.Show(String.Format("{0}", address == 0xDE ? "Game not supported!" : (address == 0xDEAD ? "Not connected to console!" : "There's another issue.")), "Holy Chit!");
                return false;
            }

            bool BO2 = (Vars.xbCon.XamGetCurrentTitleId() == (uint)Title.BO2);
            if (address != 0) {
                if (GT.Length > 0) {
                    if (BO2) Vars.xbCon.SetMemory(0x81AA2C8C, ReverseBytes(GT + "\0"));
                    Vars.xbCon.SetMemory(address, Encoding.UTF8.GetBytes(GT + "\0"));
                }
                if (XUID.Length == 16) {
                    Vars.xbCon.SetMemory(address + (uint)(BO2 ? 0x20 : 0x24), Conversion.HexStringToBytes(XUID));
                    Vars.xbCon.SetMemory(address + (uint)(BO2 ? 0x28 : 0x2C), Conversion.HexStringToBytes(Conversion.ConvertStringToHex(XUID)));
                    if (BO2) Vars.xbCon.SetMemory(0x825DE218, new byte[] { 0x48, 0x00, 0x00, 0x00 }); // XUID Check
                } else return false;
                return true;
            } return false;
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Setting XUID Was: {0}\n\nGamertag: {1}\nXUID: {2}", setXUID(xuidAddress(), tb_gt.Text, tb_xuid.Text) ? "Successful!" : "Failure!", tb_gt.Text, tb_xuid.Text));
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            if (tb_gt.Text.Length > 4 && tb_gt.Text.Length <= 15) {
                string result = GetXUID(tb_gt.Text);
                if (result == "ERR") MessageBox.Show("You're not connected to your console!");
                else if (result != "") tb_xuid.Text = result;
                else MessageBox.Show("There was an error getting the XUID! Remember, you must be online for this function to work!");
            }
        }

        private void btn_halp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I guess you're stuck. I(the windows paperclip) am here to help!\n\nGet XUID\n - Retrieve XUID By Gamertag\n - The result will automatically be put into the XUID text box.\n\nSet XUID\n - Sets XUID for all CoDs as of 6/23/2016", "Windows '98 Paperclip Here");
        }

        private void frm_xuid_Load(object sender, EventArgs e)
        {
            if (input_gt != "") {
                tb_gt.Text = input_gt;
                btn_get_Click(sender, e);
            }
        }
    }
}
