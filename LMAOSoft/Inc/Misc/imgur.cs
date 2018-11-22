using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Web;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Collections.Specialized;

namespace LMAOSoft.Misc
{
    public static class imgur
    {
        public static string Link, delHash;
        public static bool UploadImage(string location)
        {
            if (!File.Exists(location)) return false;
            using (var wc = new WebClient()) {
                wc.Headers.Add("Authorization", "Client-ID 33527b16cca2807");
                var Values = new NameValueCollection { { "image", Convert.ToBase64String(File.ReadAllBytes(location)) } };
                byte[] resp = wc.UploadValues("https://api.imgur.com/3/upload.xml", Values);
                var doc = XDocument.Load(new MemoryStream(resp));
                var xml = doc.Descendants("data")
                    .Select(x => new {
                        ID = x.Element("id").Value,
                        DeleteHash = x.Element("deletehash").Value,
                        Link = x.Element("link").Value
                    }).FirstOrDefault();

                if (xml != null) {
                    Link = xml.Link;
                    delHash = xml.DeleteHash;
                    return true;
                } return false;
            }
        }
    }
}
