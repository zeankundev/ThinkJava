using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Threading.Tasks;
using Silver_J.Localinit;

namespace Silver_J.locales
{
    public static class localmanager
    {
        private static readonly Dictionary<TjString, string> strings = new Dictionary<TjString, string>();
        private static bool init;

        public static string GetString(TjString stringenum)
        {
            if (!init)
                initial();
            return strings[stringenum];
        }

        private static void initial()
        {
            init = true;

            string region = Thread.CurrentThread.CurrentUICulture.ToString();
        }

        private static void readLocal(string p)
        {
            // checks if the desired encrypted localisation file (elf) exists
            string resfile = "locales/" + p + ".elf";
            if (!locale.localscript.FileIsThere(resfile))
                return;
            using (Stream stream = locale.localscript.FetchStream(resfile))
            using (StreamReader stream1 = new StreamReader(stream))
            {
                while (!stream1.EndOfStream)
                {
                    string line = stream1.ReadLine();
                    int index = line.IndexOf('=');
                    if (index <= 0) continue;
                    strings[(TjString)Enum.Parse(typeof(TjString), line.Remove(index), false)] = line.Substring(index + 1).Replace("\\n", "\n");
                }
            }
        }
    }

    public enum TjString
    {

    }
}
