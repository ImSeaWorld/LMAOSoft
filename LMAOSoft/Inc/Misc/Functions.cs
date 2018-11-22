using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Drawing.Imaging;

using XDevkit;
using JRPC_Client;
using FormEssentials;
using System.Windows.Forms;
using System.Reflection;
using System.Media;

namespace LMAOSoft.Misc
{
    public static class Functions
    {
        public static NotifyIcon Notify = new NotifyIcon();

        public static void ShowBaloonTip(string title, string body, ToolTipIcon icon, int duration = 3000)
        {
            Notify.Visible = true;
            Notify.BalloonTipTitle = "LMAOSoft: " + title;
            Notify.BalloonTipText = body;
            Notify.BalloonTipIcon = icon;
            Notify.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
            Notify.ShowBalloonTip(duration);
        }

        public static void PlayError()
        {
            SoundPlayer error = new SoundPlayer(Settings.ErrorSound);
            error.Play();
        }

        public static void PlaySuccess()
        {
            try {
                SoundPlayer success = new SoundPlayer(Settings.SuccessSound);
                success.Load();
                success.Play();
            } catch (Exception ex) { MessageBox.Show(ex.Message + "\r\n\r\n" + Settings.SuccessSound); }
        }
    }

    public static class Xbox
    {
        private static bool PollConnection()
        { // Not always accurate... But it's a fuck it kind of thing.
            try { return (Vars.xbCon.GetMemory(0x81AA2200, 1).Length > 0); }
            catch { return false; }
        }

        private static void DisposeConnection()
        { // Doesn't work when the console is off. But we try anyways.
            try {
                Vars.xbCon.DebugTarget.DisconnectAsDebugger();
                Vars.xbCon = null;
                Vars.xbMgr = null;
            } catch { }
        }

        public static Thread ThreadedConnection()
        {
            return new Thread(new ThreadStart(delegate {
                for (int i = 0;;i++) {
                    try {
                        var main = (System.Windows.Forms.Application.OpenForms["frm_main"] as frm_main);
                        main.Invoke(new MethodInvoker(delegate {
                            main.Status((Vars.isConnected ? "Connected" : (main.Text.Contains("Auto") ? "Auto-Connecting" : "Disconnected")));

                            if (Vars.isConnected) {
                                try {
                                    foreach (Label lbl in FormE.Labels.GetLabelsInControl("lbl_", main.ReturnGroupbox())) {
                                        lbl.ForeColor = SystemColors.ControlDarkDark;
                                    }
                                    double CPU = (double)Vars.xbDebug.Console.GetTemperature(JRPC.TemperatureType.CPU),
                                        GPU = Convert.ToDouble(Vars.xbDebug.Console.GetTemperature(JRPC.TemperatureType.GPU)),
                                        RAM = Convert.ToDouble(Vars.xbDebug.Console.GetTemperature(JRPC.TemperatureType.EDRAM)),
                                        MOBO = Convert.ToDouble(Vars.xbDebug.Console.GetTemperature(JRPC.TemperatureType.MotherBoard));
                                    main.Current(GPU, CPU, RAM, MOBO, HexTitleToName(Vars.xbCon.XamGetCurrentTitleId()), Vars.xbDebug.Threads.Count.ToString());
                                } catch { Vars.isConnected = false; }
                            } else {
                                if (!main.Text.Contains("Auto")) {
                                    foreach (Label lbl in FormE.Labels.GetLabelsInControl("lbl_", main.ReturnGroupbox())) {
                                        lbl.ForeColor = Color.Red;
                                    }
                                }
                            }
                        }));

                        if (!Vars.NotifiedDisconnection && !Vars.isConnected && Vars.NotifiedConnected) {
                            Functions.ShowBaloonTip("Console Disconnected", "Your console either shut off or we hit an error!", ToolTipIcon.Error);
                            Vars.NotifiedDisconnection = true;
                            Vars.NotifiedConnected = false;
                            Functions.PlayError();
                        }

                        if (!PollConnection() || !Vars.isConnected) {
                            Vars.xbCon = Vars.xbMgr.OpenConsole(Settings.sConsole);
                            Vars.xbDebug = Vars.xbCon.DebugTarget;
                            Vars.xbDebug.ConnectAsDebugger("LMAOSoft", XDevkit.XboxDebugConnectFlags.Force);
                            if (!Vars.NotifiedConnected) {
                                Functions.ShowBaloonTip("Yay!", "You have connected to " + Vars.xbMgr.DefaultConsole + "!", ToolTipIcon.Info);
                                Vars.NotifiedConnected = true;
                                Vars.NotifiedDisconnection = false;
                                Functions.PlaySuccess();
                            }
                            if (!Vars.isConnected) Vars.isConnected = true;
                        } Thread.Sleep(2500);
                    } catch { Vars.isConnected = false; DisposeConnection(); }
                }
            }));
        }

        public struct Titles {
            public uint title { get; set; }
            public string name { get; set; }
        };

        public static List<Titles> Titles_s;

        public static string HexTitleToName(uint title)
        {
            try {
                if (Titles_s.Count > 0 || Titles_s != null) {
                    return Titles_s.Find(x => x.title == title).name;
                } return title.ToString("X2");
            } catch { return title.ToString("X2"); }
        }

        public static string[] GetDrives()
        {
            if (Vars.isConnected) {
                return Vars.xbCon.Drives.Split(',');
            } return null;
        }

        public static void Reboot(XboxRebootFlags flags)
        {
            try { Vars.xbCon.Reboot(null, null, null, flags); } catch { }
        }
    }
}
