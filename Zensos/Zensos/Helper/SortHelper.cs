using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zensos.Exceptions;

namespace Zensos.Helper
{
    static class SortHelper
    {
        public static string[] bubbleSort(string[] array)
        {
            for (int n = array.Length; n > 1; n--)
            {
                for (int i = 0; i < (n - 1); i++)
                {
                    if (isBigger(array[i], array[i + 1]))
                    {
                        string tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                    }
                }
            }

            return array;
        }

        public static bool isBigger(string value1, string value2)
        {
            int klasse1 = 0;
            int klasse2 = 0;

            string kuerzel1 = "";
            string kuerzel2 = "";

            bool klasse1IsSek2;
            bool klasse2IsSek2;

            if (value1.Contains("-"))
            {
                klasse1IsSek2 = true;
                kuerzel1 = value1.Split('-')[1];
                klasse1 = Int32.Parse(value1.Split('-')[0]);
            }
            else
            {
                klasse1IsSek2 = false;
                kuerzel1 = value1.Substring(value1.Length - 1);
                klasse1 = Int32.Parse(value1.Substring(0, value1.Length - 1));
            }

            if (value2.Contains("-"))
            {
                klasse2IsSek2 = true;
                kuerzel2 = value2.Split('-')[1];
                klasse2 = Int32.Parse(value2.Split('-')[0]);
            }
            else
            {
                klasse2IsSek2 = false;
                kuerzel2 = value2.Substring(value2.Length - 1);
                klasse2 = Int32.Parse(value2.Substring(0, value2.Length - 1));
            }

            if (klasse1IsSek2 == true && klasse2IsSek2 == false)
                return true;
            else if (klasse1IsSek2 == false && klasse2IsSek2 == true)
                return false;

            if (klasse1 > klasse2)
                return true;
            else if (klasse2 > klasse1)
                return false;

            string[] alphabet = { "a", "b", "c", "s", "MuK", "WuN", "LuR", "IB" };

            //if (klasse1 == klasse2)
            //{
            if (findIndex(alphabet, kuerzel1) > findIndex(alphabet, kuerzel2))
                return true;
            else
                return false;
            //}

            /**
            Console.WriteLine("Value1           : " + value1);
            Console.WriteLine("Klasse 1         : " + klasse1);
            Console.WriteLine("Kuerzel 1        : " + kuerzel1);
            Console.WriteLine("Ist Klasse 1 Sek2? " + klasse1IsSek2);

            Console.WriteLine();

            Console.WriteLine("Value2           : " + value2);
            Console.WriteLine("Klasse 2         : " + klasse2);
            Console.WriteLine("Kuerzel 2        : " + kuerzel2);
            Console.WriteLine("Ist Klasse 2 Sek2? " + klasse2IsSek2);
             **/

            //throw new ClassesEqualException(value1, value2);
        }

        public static int findIndex(string[] array, string s)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(s))
                {
                    return i;
                }
            }

            Console.WriteLine("Error");
            return 99;
        }
    }
}
