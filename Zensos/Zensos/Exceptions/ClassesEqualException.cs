using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zensos.Exceptions
{
    class ClassesEqualException : Exception
    {
        string class1;
        string class2;
        public ClassesEqualException() { }
        public ClassesEqualException(string class1, string class2)
        {
            this.class1 = class1;
            this.class2 = class2;
        }
    }
}
