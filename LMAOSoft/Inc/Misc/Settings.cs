using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;

namespace LMAOSoft.Misc
{
    public static class Settings
    {
        public static bool bAutoConnect = true;
        public static string sConsole = Vars.xbMgr.DefaultConsole;

        public static string ThisLocation = Assembly.GetEntryAssembly().Location;
        public static string ThisDirectory = System.IO.Directory.GetCurrentDirectory();

        public static string ErrorSound = ThisDirectory + "\\Tones\\error.wav";
        public static string SuccessSound = ThisDirectory + "\\Tones\\connection-success.wav";
    }
}
