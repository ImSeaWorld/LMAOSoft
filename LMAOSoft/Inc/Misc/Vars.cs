using System;
using System.Text;

using XDevkit;
using JRPC_Client;

namespace LMAOSoft.Misc
{
    public static class Vars
    {
        public static IXboxFile xbFile;
        public static IXboxFiles xbFiles;
        public static XboxConsole xbCon;
        public static IXboxAutomation xbAuto;
        public static IXboxDebugTarget xbDebug;
        public static XboxManager xbMgr = new XboxManager();
        public static bool isConnected = false,
            NotifiedConnected = false,
            NotifiedDisconnection = false;
        public static string latestScreenShot;
    }

    public static class FileNames
    {
        public static string 
            launchINI = "launch.ini",
            keyvault = "kv.bin";
    }

    public static class Folders
    {
        public static string
            Recieved = "Recieved",
            Titles = "Titles",
            Logs = "Logs",
            Pictures = "Screen Shots",
            Temp = "Temp";
    }

    public enum Title : uint
    {
        DASHBOARD = 0xFFFE07D1,
        XEX_MENU = 0xFFFF0055,
        XEX_MENU_ALT = 0xC0DE9999,
        XSHELL = 0xFFFE07FF,
        GTA_V = 0x545408A7,
        COD4 = 0x415607E6,
        MW2 = 0x41560817,
        BO1 = 0x41560855,
        MW3 = 0x415608CB,
        BO2 = 0x415608C3,
        GHOSTS = 0x415608FC,
        AW = 0x41560914,
        BO3 = 0x4156091D
    };

    public enum XBDMCodes : int
    {
        SUCCESS = 0x2DA0000,
        ERROR = unchecked((Int32)0x82DA0000),
        HRESULTError = unchecked((Int32)0x80070000),

        //Error codes
        MAXCONNECT = ERROR | 0x001,
        NOSUCHFILE = ERROR | 0x002,
        NOMODULE = ERROR | 0x003,
        MEMUNMAPPED = ERROR | 0x004,
        NOTHREAD = ERROR | 0x005,
        CLOCKNOTSET = ERROR | 0x006,
        INVALIDCMD = ERROR | 0x007,
        NOTSTOPPED = ERROR | 0x008,
        MUSTCOPY = ERROR | 0x009,
        ALREADYEXISTS = ERROR | 0x00A,
        DIRNOTEMPTY = ERROR | 0x00B,
        BADFILENAME = ERROR | 0x00C,
        CANNOTCREATE = ERROR | 0x00D,
        CANNOTACCESS = ERROR | 0x00E,
        DEVICEFULL = ERROR | 0x00F,
        NOTDEBUGGABLE = ERROR | 0x010,
        BADCOUNTTYPE = ERROR | 0x011,
        COUNTUNAVAILABLE = ERROR | 0x012,
        NOTLOCKED = ERROR | 0x014,
        KEYXCHG = ERROR | 0x015,
        MUSTBEDEDICATED = ERROR | 0x016,
        INVALIDARG = ERROR | 0x017,
        PROFILENOTSTARTED = ERROR | 0x018,
        PROFILEALREADYSTARTED = ERROR | 0x019,
        ALREADYSTOPPED = ERROR | 0x01A,
        FASTCAPNOTENABLED = ERROR | 0x01B,
        NOMEMORY = ERROR | 0x01C,
        TIMEOUT = ERROR | 0x01D,
        NOSUCHPATH = ERROR | 0x01E,
        INVALID_SCREEN_INPUT_FORMAT = ERROR | 0x01F,
        INVALID_SCREEN_OUTPUT_FORMAT = ERROR | 0x020,
        CALLCAPNOTENABLED = ERROR | 0x021,
        INVALIDCAPCFG = ERROR | 0x022,
        CAPNOTENABLED = ERROR | 0x023,
        TOOBIGJUMP = ERROR | 0x024,
        FIELDNOTPRESENT = ERROR | 0x025,
        OUTPUTBUFFERTOOSMALL = ERROR | 0x026,
        PROFILEREBOOT = ERROR | 0x027,
        INVALIDSTATE = ERROR | 0x042,
        LINE_TOO_LONG = ERROR | 0x046,
        D3D_DEBUG_COMMAND_NOT_IMPLEMENTED = ERROR | 0x050,
        D3D_INVALID_SURFACE = ERROR | 0x051,
        CANNOTCONNECT = ERROR | 0x100,
        CONNECTIONLOST = ERROR | 0x101,
        FILEERROR = ERROR | 0x103,
        ENDOFLIST = ERROR | 0x104,
        BUFFER_TOO_SMALL = ERROR | 0x105,
        NOTXBEFILE = ERROR | 0x106,
        MEMSETINCOMPLETE = ERROR | 0x107,
        NOXBOXNAME = ERROR | 0x108,
        NOERRORSTRING = ERROR | 0x109,
        INVALIDSTATUS = ERROR | 0x10A,
        TASK_PENDING = ERROR | 0x150,

        //Success codes
        CONNECTED = SUCCESS | 0x001,
        MULTIRESPONSE = SUCCESS | 0x002,
        BINRESPONSE = SUCCESS | 0x003,
        READYFORBIN = SUCCESS | 0x004,
        DEDICATED = SUCCESS | 0x005,
        PROFILERESTARTED = SUCCESS | 0x006,
        FASTCAPENABLED = SUCCESS | 0x007,

        //HRESULTError codes
        ERROR_ACCESS_DENIED = HRESULTError | 0x005,
        ERROR_NOT_ENOUGH_MEMORY = HRESULTError | 0x008,
        ERROR_BAD_LENGTH = HRESULTError | 0x018,
        ERROR_INVALID_PARAMETER = HRESULTError | 0x057,
        ERROR_INVALID_NAME = HRESULTError | 0x07B,
        ERROR_BUSY = HRESULTError | 0x0AA,
        ERROR_INVALID_ORDINAL = HRESULTError | 0x0B6,
        ERROR_NO_LOG_SPACE = HRESULTError | 0x3FB,
        ERROR_SERVICE_NOT_ACTIVE = HRESULTError | 0x426,
        ERROR_NOT_FOUND = HRESULTError | 0x490,
    }
}
