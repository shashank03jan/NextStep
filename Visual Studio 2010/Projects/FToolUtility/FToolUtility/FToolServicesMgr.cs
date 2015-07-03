using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace FToolUtility
{
    public class FToolServicesMgr
    {
        private CookieContainer _cookies;
        private string _server = "";
        public void DownloadHTMLVersions(ref int[] versions, string folder)
        {
            WebClient client = new WebClient();
            client.Headers.Add("Cookie", this._cookies.GetCookieHeader(new Uri("http://" + this._server)));
            //string str = "https://" + this._server + "/CIQDotNet/Filings/SECPopupInner.aspx?versionId=";
            string str = "https://" + this._server + "/CIQDotNet/Service/Documents/DownloadVersion.axd?versionId=";

            foreach (int num in versions)
            {
                string fileName = folder + @"\" + num.ToString() + ".html";
                string address = string.Concat(new object[] { str, num.ToString(), "&type=", DocumentOutputType.html });
                client.DownloadFile(address, fileName);
                Console.WriteLine("File download complete:{0}", fileName);
            }
        }

        private void DownloadVersions(string cookies, int[] versions, string folder)
        {
            WebClient client = new WebClient();
            CookieContainer container = this.ParseCookies(cookies);
            client.Headers.Add("Cookie", container.GetCookieHeader(new Uri("http://" + this._server)));
            string str = "https://" + this._server + "/CIQDotNet/Service/Documents/DownloadVersion.axd?versionId=";
            foreach (int num in versions)
            {
                string fileName = folder + @"\" + num.ToString() + ".txt";
                string address = string.Concat(new object[] { str, num.ToString(), "&type=", DocumentOutputType.raw });
                client.DownloadFile(address, fileName);
                Console.WriteLine("File download complete:{0}", fileName);
            }
        }

        public void DownloadVersions(ref int[] versions, string folder, string fileExtension)
        {
            WebClient client = new WebClient();
            client.Headers.Add("Cookie", this._cookies.GetCookieHeader(new Uri("http://" + this._server)));
            string str = "https://" + this._server + "/CIQDotNet/Service/Documents/DownloadVersion.axd?versionId=";
            foreach (int num in versions)
            {
                string fileName = folder + @"\" + num.ToString() + "." + fileExtension;
                string address = string.Concat(new object[] { str, num.ToString(), "&type=", DocumentOutputType.raw });
                client.DownloadFile(address, fileName);
                Console.WriteLine("File download complete:{0}", fileName);
            }
        }
        private CookieContainer ParseCookies(string cookies)
        {
            CookieCollection cookies2 = new CookieCollection();
            foreach (string str in cookies.Split(new char[] { ';' }))
            {
                string name = str.Split(new char[] { '=' })[0].Trim();
                string str3 = str.Split(new char[] { '=' })[1].Trim();
                Cookie cookie = new Cookie(name, str3);
                cookies2.Add(cookie);
            }
            CookieContainer container = new CookieContainer();
            container.Add(new Uri("http://" + this._server), cookies2);
            return container;
        }
    }
    public enum DocumentOutputType
    {
        html,
        xls,
        doc,
        pdf,
        blk,
        raw
    }
}
