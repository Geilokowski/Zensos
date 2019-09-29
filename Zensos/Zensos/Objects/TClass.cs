using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zensos.Objects
{
    class TClass
    {
        private string classStr;
        public TClass(string str)
        {
            classStr = str;
        }

        public int getClass()
        {
            if (classStr.Contains("-"))
                return Int32.Parse(classStr.Split('-')[0]);
            else
                return Int32.Parse(classStr.Substring(0, classStr.Length - 1));
        }

        public string GetKZ()
        {
            if (classStr.Contains("-"))
                return classStr.Split('-')[1];
            else
                return classStr.Substring(classStr.Length - 1);
        }

        public bool IsSek2()
        {
            if (classStr.Contains("-"))
                return true;
            else
                return false;
        }

        public static string getKZFromStr(string str)
        {
            if (str.Contains("-"))
                return str.Split('-')[1];
            else
                return str.Substring(str.Length - 1);
        }
    }
}
