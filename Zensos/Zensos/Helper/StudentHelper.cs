using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zensos.Objects;

namespace Zensos.Helper
{
    class StudentHelper
    {
        public static List<String> getCurrentClasses(List<TSchueler> studentList)
        {
            List<String> classList = new List<string>();
            foreach (TSchueler student in studentList)
            {
                classList.Add(student.Klasse);
            }

            return classList.Distinct().ToList();
        }

        public static List<String> getJGKZsForStudents(List<TSchueler> students)
        {
            List<String> KZList = new List<string>();
            foreach (TSchueler student in students)
            {
                KZList.Add("JG" + student.AufnahmeJahrgang.ToString().Substring(2) + TClass.getKZFromStr(student.Klasse));
            }

            return KZList;
        }
    }
}
