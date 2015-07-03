using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            FToolUtility.FToolServicesMgr mgr = new FToolUtility.FToolServicesMgr();
            int[] ver=new int[1]{1379674933};

            mgr.DownloadHTMLVersions(ref ver, "C:\\FundamenTool\\Docs\\ver");
        }
    }
}
