using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zensos.Exceptions
{
    class TableNotFoundException : Exception
    {
        string path;
        public TableNotFoundException() { }
        public TableNotFoundException(string path)
        {
            this.path = path;
        }
        public string getPath()
        {
            return path;
        }
    }
}
