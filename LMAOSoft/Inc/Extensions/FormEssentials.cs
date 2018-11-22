using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace FormEssentials
{
    public static class FormE
    {
        public static bool isFormOpen(Form frm)
        {
            return Application.OpenForms[frm.Name] as Form != null;
        }

        public static Form returnForm(Form form)
        {
            return Application.OpenForms[form.Name] as Form;
        }

        public static class TextBoxes
        {
            public static List<TextBox> GetTextBoxesByNum(string name, Control control)
            {
                List<TextBox> tb = new List<TextBox>();
                foreach (Control con in control.Controls)
                    if (con.Name.Contains(name))
                        tb.Add(con as TextBox);
                return tb.OrderByDescending(x => int.Parse(x.Name.Replace(name, ""))).AsEnumerable().Reverse().ToList();
            }
        }

        public static class Labels
        {
            public static List<Label> GetLabelsInControl(string name, Control control)
            {
                List<Label> lbl = new List<Label>();
                foreach (Control con in control.Controls)
                    if (con.Name.Contains(name))
                        lbl.Add(con as Label);
                return lbl;
            }
        }

        public static class ListViews
        {
            public static void addToListView(ListView LeListView, string item, params object[] moreItems)
            {
                if (LeListView == null)
                    throw new Exception("Listview is null!");
                ListViewItem lv_item = new ListViewItem(item);
                if (moreItems.Length > 0)
                    for (int i = 0; i < moreItems.Length; i++)
                    {
                        if (moreItems[i] == null)
                            throw new Exception(String.Format("Item {0} is null.", i.ToString()));
                        lv_item.SubItems.Add(moreItems[i].ToString());
                    }
                LeListView.Items.Add(lv_item);
            }

            public static bool doesItemExistLV(ListView LeListView, string search)
            {
                foreach (ListViewItem lv_item in LeListView.Items)
                    if (lv_item.Text.ToLower() == search.ToLower())
                        return true;
                    else return false;
                return false;
            }

            public static bool doesItemContainLV(ListView LeListView, string search, int loc)
            {
                foreach (ListViewItem lv_item in LeListView.Items)
                    if (lv_item.SubItems[loc].Text.ToLower().Contains(search.ToLower()))
                        return true;
                    else return false;
                return false;
            }

            public static int whereIsInLV(ListView lv, string search)
            {
                if (lv.Items.Count > 0)
                    for (int x = 0; x < lv.Items.Count; x++)
                        if (lv.Items[x].Text == search)
                            return x;
                return -1;
            }

            public static void removeDupesLV(ListView lv)
            {
                if (lv.Items.Count > 0)
                    for (int x = 0; x < lv.Items.Count; x++)
                        for (int y = 1; y < lv.Items.Count; y++)
                            if (x != y)
                                if (lv.Items[x].Text == lv.Items[y].Text)
                                    lv.Items[y].Remove();
            }
        }
    }

    public static class Encodings
    {
        public static string Base64(string input, bool encode = true)
        {
            return encode ? Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input)) : System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(input));
        }
    }

    public static class Hashing
    {
        public static string MD5(byte[] arg)
        {
            string result = "";
            MD5CryptoServiceProvider _MD5 = new MD5CryptoServiceProvider();
            _MD5.ComputeHash(arg);
            for (int i = 0; i < _MD5.Hash.Length; i++)
            {
                result += _MD5.Hash[i].ToString("x2");
            } return result;
        }

        public static string MD5(string arg) { return MD5(Encoding.ASCII.GetBytes(arg)); }
        public static string MD5(FileStream arg) { return MD5(arg); }
    }

    public static class Conversion
    {
        public static string BytesToHexString(byte[] Buffer)
        {
            string str = "";
            for (int i = 0; i < Buffer.Length; i++)
                str = str + Buffer[i].ToString("X2");
            return str;
        }

        public static string ConvertStringToHex(string asciiString)
        {
            string hex = "";
            foreach (char c in asciiString)
                hex += String.Format("{0:x2}", (uint)System.Convert.ToUInt32(c));
            return hex;
        }

        public static byte[] HexStringToBytes(string hex)
        {
            Func<int, byte> func2 = null;
            try {
                hex = hex.Replace(" ", "").Replace("0x", "");
                if (func2 == null)
                    func2 = x => Convert.ToByte(hex.Substring(x, 2), 0x10);
                Func<int, byte> selector = func2;
                return (from x in Enumerable.Range(0, hex.Length)
                        where (x % 2) == 0
                        select x).Select<int, byte>(selector).ToArray<byte>();
            } catch (Exception) { return new byte[1]; }
        }
    }

    public static class SelfHashing
    {
        public static string GetExecutingFileHash()
        {
            return MD5(GetSelfBytes());
        }

        private static string MD5(byte[] input)
        {
            return MD5(ASCIIEncoding.ASCII.GetString(input));
        }

        private static string MD5(string input)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] originalBytes = ASCIIEncoding.Default.GetBytes(input);
            byte[] encodedBytes = md5.ComputeHash(originalBytes);
            return BitConverter.ToString(encodedBytes).Replace("-", "");
        }

        private static byte[] GetSelfBytes()
        {
            string path = Application.ExecutablePath;
            FileStream running = File.OpenRead(path);
            byte[] exeBytes = new byte[running.Length];
            running.Read(exeBytes, 0, exeBytes.Length);
            running.Close();
            return exeBytes;
        }
    }

    public static class RC4ex
    {
        public static void RC4(ref byte[] Data, byte[] Key)
        {
            byte num;
            int num2;
            byte[] buffer = new byte[0x100];
            byte[] buffer2 = new byte[0x100];
            for (num2 = 0; num2 < 0x100; num2++)
            {
                buffer[num2] = (byte)num2;
                buffer2[num2] = Key[num2 % Key.GetLength(0)];
            }
            int index = 0;
            for (num2 = 0; num2 < 0x100; num2++)
            {
                index = ((index + buffer[num2]) + buffer2[num2]) % 0x100;
                num = buffer[num2];
                buffer[num2] = buffer[index];
                buffer[index] = num;
            }
            num2 = index = 0;
            for (int i = 0; i < Data.GetLength(0); i++)
            {
                num2 = (num2 + 1) % 0x100;
                index = (index + buffer[num2]) % 0x100;
                num = buffer[num2];
                buffer[num2] = buffer[index];
                buffer[index] = num;
                int num5 = (buffer[num2] + buffer[index]) % 0x100;
                Data[i] = (byte)(Data[i] ^ buffer[num5]);
            }
        }
    }

    public class IniFile
    {
        public string path;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
                 string key, string def, StringBuilder retVal,
            int size, string filePath);

        public IniFile(string INIPath) { path = INIPath; }

        public void IniWriteValue(string Section, string Key, string Value)
        { WritePrivateProfileString(Section, Key, Value, path); }

        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, path);
            return temp.ToString();
        }
    }

    public static class Bytes
    {
        public static byte[] ReverseBytes(byte[] input) { return input.Reverse().ToArray(); }
        public static byte[] ReverseBytes(string input) { return Encoding.UTF8.GetBytes(input).Reverse().ToArray(); }

        public static bool isEmpty(byte[] input) { return input.Length <= 0; }

        public static bool ComapareBytes(byte[] input1, byte[] input2)
        {
            if (input1.Length != input2.Length)
                return false;
            for (int i = 0; i < input1.Length; i++)
                if (input1[i] != input2[i])
                    return false;
            return true;
        }

        // Checks if byte array is empty.
        public static bool IsEmptyBlock(byte[] input)
        {
            for (int i = 0; i < input.Length; i++)
                if (input[i] != 0x00)
                    return false;
            return true;
        }

        public static byte[] FillBlock(byte Value, int Length)
        {
            if (Length < 2) return null;
            byte[] Buffer = new byte[Length];
            for (int i = 0; i < Length; i++) {
                Buffer[i] = Value;
            } return Buffer;
        }
    }

    public static class FileEx
    {
        public static byte[] ReadBytes(string FileLocation, int Ordinal, int Length)
        {
            byte[] TempBuffer = new byte[Length];
            using (FileStream fs = new FileStream(FileLocation, FileMode.Open, FileAccess.Read)) {
                fs.Read(TempBuffer, Ordinal, Length);
            } return TempBuffer;
        }
    }

    public class Blocks
    {
        private byte[] InputBytes;
        public Blocks(byte[] input)
        {
            if (!Bytes.isEmpty(input)) {
                InputBytes = input;
            } else { throw new Exception("Input array is empty!"); }
        }

        public byte[] GetChunk(int Position, int Length)
        {
            if (Length > InputBytes.Length)
                throw new Exception("Input length is larger than array length.");
            if (Position > InputBytes.Length)
                throw new Exception("Input position is larger than array length.");

            byte[] Chunk = new byte[Length];
            Array.Copy(InputBytes, Position, Chunk, 0, Length);
            return (!Bytes.isEmpty(Chunk) ? Chunk : null);
        }
    }

    public static class DateTimes
    {
        public static string TimeElapsed(DateTime date1, DateTime date2)
        {
            TimeSpan ts = (date1 > date2 ? (date1 - date2) : (date2 - date1));
            // Build format
            string[] Text = new string[6] { "Year", "Month", "Day", "Hour", "Minute", "Second" };
            for (int i = 0; i < 6; i++) {
                switch (i) {
                    case 0: break;
                    case 1: break;
                    case 2: break;
                    case 3: break;
                    case 4: break;
                    case 5: break;
                }
            }
            return String.Format("{0} Year(s), {1} Month(s), {2} Day(s), {3} Hour(s), {4} Minute(s), {5} Second(s)", Math.Truncate(ts.TotalDays / 365), Math.Truncate(ts.TotalDays % 365) / 30, Math.Truncate(ts.TotalDays % 365) % 30, ts.Hours, ts.Minutes, ts.Seconds);
        }
    }

    public static class WindowsConsole
    {
        public static bool ExecConsole(string cmd, bool runas = false, ProcessWindowStyle style = ProcessWindowStyle.Hidden)
        {
            try
            {
                Process proc = new Process();
                ProcessStartInfo procStartInfo = new ProcessStartInfo();
                procStartInfo.WindowStyle = style;
                procStartInfo.Verb = runas ? "runas" : "";
                procStartInfo.FileName = "cmd.exe";
                procStartInfo.Arguments = cmd;
                proc.StartInfo = procStartInfo;
                proc.Start();
                return true;
            }
            catch { return false; }
        }
    }
}