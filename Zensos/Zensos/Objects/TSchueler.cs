using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zensos
{
    class TSchueler : TPerson
    {
        public readonly int AufnahmeJahrgang;
        public int AbschlussJahrgang;
        public string JahrgangKZ;
        public string Klasse;

        public TSchueler(
            int _AufnahmeJahrgang, int _AbschlussJahrgang, string _JahrgangKZ, string _Klasse
            , string _GeburtsName, string _Name, string _Vorname
            , bool _Geschlecht, string _GeburtsDatum
            )
            : base(_GeburtsName, _Name, _Vorname, _Geschlecht, _GeburtsDatum)
        {
            JahrgangKZ = _JahrgangKZ;
            Klasse = _Klasse;
            AufnahmeJahrgang = _AufnahmeJahrgang;
            AbschlussJahrgang = _AbschlussJahrgang;
        }
    }
}
