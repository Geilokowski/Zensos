using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zensos.Helper
{
    class ConsoleHelper
    {
        public static void OutputStr(List<string> strList)
        {
            string tmp = "";
            foreach (string str in strList)
            {
                tmp = tmp + str + ", ";
            }

            if (tmp.Length > 2)
                Console.WriteLine(tmp.Substring(0, tmp.Length - 2));
            else
                Console.WriteLine("Error 0x1");
        }

        public static void OutputStr(List<TSchueler> firstStr, List<string> secondStr)
        {
            try
            {
                for (int i = 0; i < firstStr.Count; i++)
                {
                    Console.WriteLine(OutputStr(firstStr[i].Vorname + " " + firstStr[i].Name, GetLongestNameLenght(firstStr)) + " --> " + secondStr[i]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error 0x2 (Index our of Bound)");
            }

            Console.WriteLine();
        }

        public static void OutputSortedListAfterClass(List<TSchueler> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(OutputStr((i + 1) + ". " + list[i].Vorname + " " + list[i].Name, GetLongestNameLenghtPlusPrefix(list)) + " [" + list[i].Klasse + "]");
            }

            Console.WriteLine();
        }

        public static void OutputSortedListAfterJGKZ(List<TSchueler> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(OutputStr((i + 1) + ". " + list[i].Vorname + " " + list[i].Name, GetLongestNameLenghtPlusPrefix(list)) + " [" + list[i].JahrgangKZ + "]");
            }

            Console.WriteLine();
        }

        public static void OutputSortedListAfterName(List<TSchueler> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + list[i].Vorname + " " + list[i].Name);
            }

            Console.WriteLine();
        }

        private static int GetLongestNameLenghtPlusPrefix(List<TSchueler> list)
        {
            int longest = 0;
            foreach(TSchueler student in list)
            {
                if (longest < (student.Vorname.Length + student.Name.Length + 1))
                    longest = (student.Vorname.Length + student.Name.Length + 1);
            }

            longest = longest + (int) Math.Floor(Math.Log10(list.Count) + 1) + 2;
            return longest;
        }

        private static string OutputStr(string str, int longest)
        {
            int charsToAdd = longest - str.Length;

            while(charsToAdd > 0)
            {
                str = str + " ";
                charsToAdd--;
            }

            return str;
        }

        private static int GetLongestNameLenght(List<TSchueler> list)
        {
            int longest = 0;
            foreach (TSchueler student in list)
            {
                if (longest < (student.Vorname.Length + student.Name.Length + 1))
                    longest = (student.Vorname.Length + student.Name.Length + 1);
            }

            return longest;
        }

        private static int GetLongestNameLenght(List<string> list)
        {
            int longest = 0;
            foreach (string str in list)
            {
                if (longest < (str.Length))
                    longest = (str.Length);
            }

            return longest;
        }

        public static void OutputStudents(List<TSchueler> list)
        {
            List<string> tmp = generateStrForJGKZ(list);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(OutputStr(tmp[i], GetLongestNameLenght(tmp)) + " [" + list[i].JahrgangKZ + "]");
            }

            Console.WriteLine();
        }

        public static void OutputJGKZWithClass(List<TSchueler> list, List<string> strList)
        {
            List<string> tmp = generateStrForJGKZ(list);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(OutputStr(tmp[i], GetLongestNameLenght(tmp)) + " --> " + "[" + strList[i] + "]");
            }

            Console.WriteLine();
        }

        public static List<string> generateStrForJGKZ(List<TSchueler> list)
        {
            List<string> returnList = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                returnList.Add(OutputStr(list[i].Vorname + " " + list[i].Name, GetLongestNameLenght(list)) + " [" + list[i].Klasse + "]");
            }

            return returnList;
        }
    }
}
