using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zensos.Objects
{
    class TJGKZ
    {
        private string jgkzStr;
        public TJGKZ(string JGKZ)
        {
            jgkzStr = JGKZ;
        }

        public int JG()
        {
            return Int32.Parse(jgkzStr.Substring(2,2));
        }

        public string KZ()
        {
            return jgkzStr.Substring(4, jgkzStr.Length - 4);
        }
    }
}
