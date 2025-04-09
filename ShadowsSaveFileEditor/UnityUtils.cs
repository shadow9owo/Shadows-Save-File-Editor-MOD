using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms.Design;

namespace ShadowsSaveFileEditor
{
    class UnityUtils
    {
        public static string getpersistantpath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).Replace("Local", "LocalLow") + "\\TVGS" + "\\Schedule I\\".ToString();
        }

        public static void exit()
        {
            Process.GetCurrentProcess().Kill();
            return;
        }

        public static List<string> getobjects() //horrible
        {
            List<string> c = new List<string>();
            var b = getpersistantpath();
            foreach (var file in Directory.GetFiles(b, "*.json", SearchOption.AllDirectories))
            {
                c.Add(file);
            }
            return c;
        }

        public static List<string> getobjects_usr()
        {
            List<string> c = new List<string>();
            var b = Data.userselectedroot;
            foreach (var file in Directory.GetFiles(b, "*.json", SearchOption.AllDirectories))
            {
                c.Add(file);
            }
            return c;
        }
        public static string captext(string main,int lenght)
        {
            string a = "";
            for (int i = 0; i < main.Length; i++)
            {
                if (i > lenght)
                {
                    a = a + "...";
                    return a;
                }else
                {
                    a = a + main[i];
                }
            }
            return a;
        }
    }
}
