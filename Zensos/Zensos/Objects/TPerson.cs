using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zensos
{
    class TPerson
    {
        public string Name;
        public string Vorname;
        public bool Geschlecht;
        public readonly DateTime GeburtsDatum;
        public readonly DateTime Geburtstag;
        public readonly int Alter;
        public readonly string UserNameID;
        public readonly string GeburtsName;

        public TPerson(string _GeburtsName, string _Name, string _Vorname, bool _Geschlecht, string _GeburtsDatum)
        {
            GeburtsName = _GeburtsName;
            Name = _Name;
            Vorname = _Vorname;
            Geschlecht = _Geschlecht;
            GeburtsDatum = DateTime.Parse(_GeburtsDatum);
            Geburtstag = GebeGeburtsTagAn();
            Alter = BerechneAlter();
            UserNameID = CreateUserName();

        }
        public DateTime GebeGeburtsTagAn()
        {
            return DateTime.Parse(string.Join(".", GeburtsDatum.Day.ToString(), GeburtsDatum.Month.ToString(), DateTime.Now.Year.ToString()));
        }
        public int BerechneAlter()
        {
            int JahresDifferenz = DateTime.Now.Year - GeburtsDatum.Year;
            if
              (GebeGeburtsTagAn().CompareTo(DateTime.Now) > 0)
            { JahresDifferenz--; }

            return JahresDifferenz;
        }

        public static string CheckNameString(string name)
        {
            Char[] Separatoren = { ' ', '-' };
            var ForbiddenChar = new List<String> { "ä", "ö", "ü", "ß", "á", "é", "ó" };
            var ReplacementStr = new List<String> { "ae", "oe", "ue", "ss", "a", "e", "o" };

            String aname = name.Trim().ToLower();


            int SepIndex = aname.IndexOfAny(Separatoren);
            if (SepIndex > -1) aname = aname.Remove(SepIndex);

            int zaehler = -1;
            foreach (String ZeichenF in ForbiddenChar)
            {
                zaehler++;
                aname = aname.Replace(ZeichenF, ReplacementStr[zaehler]);
            }

            return aname;
        }

        internal string CreateUserName()
        {
            string uVorname = CheckNameString(Vorname);
            string uName = Name.ToLower();
            var ForbiddenStrings = new List<String> { "von ", "zu ", "la ", "del ", "de ", "de la " };

            foreach (String TeilString in ForbiddenStrings)
                uName = uName.Replace(TeilString, "");
            uName = uName.Trim();
            uName = CheckNameString(uName);

            return uVorname + "." + uName;
        }

    }
}
