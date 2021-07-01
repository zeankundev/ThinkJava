using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Silver_J.Localinit
{
    class locale
    {
        internal static locale localscript { get; private set; }

        public locale()
        {
            localscript = this;
        }

        internal virtual bool FileIsThere(string file)
        {
            return File.Exists(file);
        }

        internal virtual Stream FetchStream(string file)
        {
            return File.OpenRead(file);
        }

        internal virtual byte[] FetchBytes(string file)
        {
            return File.ReadAllBytes(file);
        }
    }
}
