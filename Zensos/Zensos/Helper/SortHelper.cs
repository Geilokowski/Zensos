using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zensos.Exceptions;
using Zensos.Objects;

namespace Zensos.Helper
{
    static class SortHelper
    {
        public static List<TSchueler> bubbleSortClass(List<TSchueler> list)
        {
            for (int n = list.Count; n > 1; n--)
            {
                for (int i = 0; i < (n - 1); i++)
                {
                    if (isBiggerClass(list[i].Klasse, list[i + 1].Klasse))
                    {
                        TSchueler tmp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = tmp;
                    }
                }
            }

            return list;
        }

        public static List<TSchueler> bubbleSortJGKZ(List<TSchueler> list)
        {
            for (int n = list.Count; n > 1; n--)
            {
                for (int i = 0; i < (n - 1); i++)
                {
                    if (isBiggerJGKZ(list[i].JahrgangKZ, list[i + 1].JahrgangKZ))
                    {
                        TSchueler tmp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = tmp;
                    }
                }
            }

            return list;
        }

        public static List<TSchueler> bubbleSortName(List<TSchueler> list)
        {
            for (int n = list.Count; n > 1; n--)
            {
                for (int i = 0; i < (n - 1); i++)
                {
                    if (isBiggerName((list[i].Vorname + list[i].Name), (list[i + 1].Vorname + list[i + 1].Name)))
                    {
                        TSchueler tmp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = tmp;
                    }
                }
            }

            return list;
        }

        public static List<TSchueler> bubbleSortClassAndName(List<TSchueler> list)
        {
            List<TSchueler> students = bubbleSortClass(list);
            List<List<TSchueler>> classList = new List<List<TSchueler>>();
            List<TSchueler> returnList = new List<TSchueler>();
            string currentClass = "";
            
            // Create 2D Array
            foreach (TSchueler student in students)
            {
                if (currentClass.Equals(student.Klasse))
                {
                    classList.Last().Add(student);
                }
                else
                {
                    classList.Add(new List<TSchueler>());
                    classList.Last().Add(student);
                    currentClass = student.Klasse;
                }
            }

            // Sorting each Array individually
            for (int i = 0; i < classList.Count; i++)
            {
                classList[i] = bubbleSortName(classList[i]);
            }

            // Putting it back together
            foreach (List<TSchueler> subList in classList)
            {
                foreach(TSchueler student in subList)
                {
                    returnList.Add(student);
                }
            }

            return returnList;
        }

        public static bool isBiggerClass(string value1, string value2)
        {
            TClass class1 = new TClass(value1);
            TClass class2 = new TClass(value2);

            if (class1.IsSek2() == true && class2.IsSek2() == false)
                return true;
            else if (class1.IsSek2() == false && class2.IsSek2() == true)
                return false;

            if (class1.getClass() > class2.getClass())
                return true;
            else if (class2.getClass() > class1.getClass())
                return false;

            if (findIndex(Statics.courses, class1.GetKZ()) > findIndex(Statics.courses, class2.GetKZ()))
                return true;
            else
                return false;
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

        public static bool isBiggerJGKZ(string value1, string value2)
        {
            TJGKZ JGKZ1 = new TJGKZ(value1);
            TJGKZ JGKZ2 = new TJGKZ(value2);

            if (JGKZ1.JG() > JGKZ2.JG())
                return true;
            else if (JGKZ2.JG() > JGKZ1.JG())
                return false;

            if (findIndex(Statics.courses, JGKZ1.KZ()) > findIndex(Statics.courses, JGKZ2.KZ()))
                return true;
            else
                return false;
        }

        public static bool isBiggerName(string value1, string value2)
        {
            value1 = TPerson.CheckNameString(value1).ToLower();
            value2 = TPerson.CheckNameString(value2).ToLower();

            for (int i = 0; i < biggerInt(value1.Length, value2.Length); i++)
            {
                if (i == value1.Length && i < value2.Length)
                    return false;

                if (i < value1.Length && i == value2.Length)
                    return true;

                if (findIndex(Statics.alphabet, value1.ToCharArray()[i]) > findIndex(Statics.alphabet, value2.ToCharArray()[i]))
                    return true;

                if (findIndex(Statics.alphabet, value1.ToCharArray()[i]) < findIndex(Statics.alphabet, value2.ToCharArray()[i]))
                    return false;
            }

            return false;
        }

        public static int findIndex(char[] array, char s)
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

        private static int biggerInt(int int1, int int2)
        {
            if (int1 > int2)
                return int1;
            else
                return int2;
        }
    }
}
