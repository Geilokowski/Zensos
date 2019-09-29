using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zensos
{
    class TKlassenUebersicht
    {
        public readonly String AktuellesSchuljahr;
        public readonly Int32 ReferenzJahr;
        public readonly List<String> JGKlassenstufenReferenzListe;
        public readonly List<String> KlassenReferenzListe;
        public readonly List<String> JGKZReferenzListe;

        public readonly List<String> Klassenstufe5;
        public readonly List<String> Klassenstufe6;
        public readonly List<String> Klassenstufe7;
        public readonly List<String> Klassenstufe8;
        public readonly List<String> Klassenstufe9;
        public readonly List<String> Klassenstufe10;
        public readonly List<List<String>> GrundStufe;
        public readonly List<List<String>> SekundarStufe1;
        public readonly List<String> Profil_11_IB;
        public readonly List<String> Profil_12_IB;
        public readonly List<List<String>> Profil_IB;
        public readonly List<String> Profil_11_LuR;
        public readonly List<String> Profil_12_LuR;
        public readonly List<List<String>> Profil_LuR;
        public readonly List<String> Profil_11_WuN;
        public readonly List<String> Profil_12_WuN;
        public readonly List<List<String>> Profil_WuN;
        public readonly List<String> Profil_11_MuK;
        public readonly List<String> Profil_12_MuK;
        public readonly List<List<String>> Profil_MuK;
        public readonly List<String> Klassenstufe11;
        public readonly List<String> Klassenstufe12;
        public readonly List<List<String>> SekundarStufe2;

        public TKlassenUebersicht()
        {
            DateTime StichTag = DateTime.Parse("01.08." + DateTime.Now.Year.ToString());
            DateTime ADatum = DateTime.Now;
            if (ADatum < StichTag)
            {
                ReferenzJahr = StichTag.AddYears(-1).Year;
                AktuellesSchuljahr = ReferenzJahr.ToString() + "/" + StichTag.Year.ToString();
            }
            else
            {
                ReferenzJahr = StichTag.Year;
                AktuellesSchuljahr = ReferenzJahr.ToString() + "/" + StichTag.AddYears(1).Year.ToString();
            }

            Klassenstufe5 = new List<String> { "5s" };
            Klassenstufe6 = new List<String> { "6s" };
            Klassenstufe7 = new List<String> { "7a", "7b", "7s", "7s-1", "7s-2" };
            Klassenstufe8 = new List<String> { "8a", "8b", "8s", "8s-1", "8s-2" };
            Klassenstufe9 = new List<String> { "9a", "9b", "9s", "9s-1", "9s-2" };
            Klassenstufe10 = new List<String> { "10a", "10b", "10s", "10s-1", "10s-2" };

            GrundStufe = new List<List<String>> {
                    Klassenstufe5
                    ,Klassenstufe6
                };

            SekundarStufe1 = new List<List<String>> {
                    Klassenstufe7
                    ,Klassenstufe8
                    ,Klassenstufe9
                    ,Klassenstufe10
                };

            Profil_11_IB = new List<String> { "11-IB", "11-IB1", "11-IB2" };
            Profil_12_IB = new List<string> { "12-IB", "12-IB1", "12-IB2" };
            Profil_IB = new List<List<String>> { Profil_11_IB, Profil_12_IB };

            Profil_11_LuR = new List<String> { "11-LuR", "11-LuR1", "11-LuR2" };
            Profil_12_LuR = new List<string> { "12-LuR", "12-LuR1", "12-LuR2" };
            Profil_LuR = new List<List<String>> { Profil_11_LuR, Profil_12_LuR };

            Profil_11_WuN = new List<String> { "11-WuN", "11-WuN1", "11-WuN2" };
            Profil_12_WuN = new List<string> { "12-WuN", "12-WuN1", "12-WuN2" };
            Profil_WuN = new List<List<String>> { Profil_11_WuN, Profil_12_WuN };

            Profil_11_MuK = new List<String> { "11-MuK", "11-MuK1", "11-MuK2" };
            Profil_12_MuK = new List<string> { "12-MuK", "12-MuK1", "12-MuK2" };
            Profil_MuK = new List<List<String>> { Profil_11_MuK, Profil_12_MuK };


            Klassenstufe11 = new List<String> { };
            foreach (String ProfilKlasse in Profil_11_IB)  { Klassenstufe11.Add(ProfilKlasse); };
            foreach (String ProfilKlasse in Profil_11_LuR) { Klassenstufe11.Add(ProfilKlasse); };
            foreach (String ProfilKlasse in Profil_11_WuN) { Klassenstufe11.Add(ProfilKlasse); };
            foreach (String ProfilKlasse in Profil_11_MuK) { Klassenstufe11.Add(ProfilKlasse); };

            Klassenstufe12 = new List<String> { };
            foreach (String ProfilKlasse in Profil_12_IB)  { Klassenstufe12.Add(ProfilKlasse); };
            foreach (String ProfilKlasse in Profil_12_LuR) { Klassenstufe12.Add(ProfilKlasse); };
            foreach (String ProfilKlasse in Profil_12_WuN) { Klassenstufe12.Add(ProfilKlasse); };
            foreach (String ProfilKlasse in Profil_12_MuK) { Klassenstufe12.Add(ProfilKlasse); };

            SekundarStufe2 = new List<List<String>>
                {
                    Klassenstufe11
                    ,Klassenstufe12
                };

            KlassenReferenzListe = new List<String> { };

            foreach (String Klasse in Klassenstufe5)  { KlassenReferenzListe.Add(Klasse); };
            foreach (String Klasse in Klassenstufe6)  { KlassenReferenzListe.Add(Klasse); };
            foreach (String Klasse in Klassenstufe7)  { KlassenReferenzListe.Add(Klasse); };
            foreach (String Klasse in Klassenstufe8)  { KlassenReferenzListe.Add(Klasse); };
            foreach (String Klasse in Klassenstufe9)  { KlassenReferenzListe.Add(Klasse); };
            foreach (String Klasse in Klassenstufe10) { KlassenReferenzListe.Add(Klasse); };
            foreach (String Klasse in Profil_11_IB)   { KlassenReferenzListe.Add(Klasse); };
            foreach (String Klasse in Profil_11_LuR)  { KlassenReferenzListe.Add(Klasse); };
            foreach (String Klasse in Profil_11_WuN)  { KlassenReferenzListe.Add(Klasse); };
            foreach (String Klasse in Profil_11_MuK)  { KlassenReferenzListe.Add(Klasse); };
            foreach (String Klasse in Profil_12_IB)   { KlassenReferenzListe.Add(Klasse); };
            foreach (String Klasse in Profil_12_LuR)  { KlassenReferenzListe.Add(Klasse); };
            foreach (String Klasse in Profil_12_WuN)  { KlassenReferenzListe.Add(Klasse); };
            foreach (String Klasse in Profil_12_MuK)  { KlassenReferenzListe.Add(Klasse); };

            JGKlassenstufenReferenzListe = new List<String> { };

            for (int i = 5; i <= 6; i++)
            {
                JGKlassenstufenReferenzListe.Add("JG" + (ReferenzJahr - 1995 - i).ToString());
            };
            for (int i = 7; i <= 10; i++)
            {
                JGKlassenstufenReferenzListe.Add("JG" + (ReferenzJahr - 1993 - i).ToString());
            };
            for (int i = 11; i <= 12; i++)
            {
                JGKlassenstufenReferenzListe.Add("JG" + (ReferenzJahr - 1989 - i).ToString());
            };

            JGKZReferenzListe = new List<String> { };

            foreach (String Klasse in Klassenstufe5)
            {
                JGKZReferenzListe.Add(JGKlassenstufenReferenzListe[0] + Klasse.Substring(1, Klasse.Length - 1));
            };
            foreach (String Klasse in Klassenstufe6)
            {
                JGKZReferenzListe.Add(JGKlassenstufenReferenzListe[1] + Klasse.Substring(1, Klasse.Length - 1));
            };
            foreach (String Klasse in Klassenstufe7)
            {
                JGKZReferenzListe.Add(JGKlassenstufenReferenzListe[2] + Klasse.Substring(1, Klasse.Length - 1));
            };
            foreach (String Klasse in Klassenstufe8)
            {
                JGKZReferenzListe.Add(JGKlassenstufenReferenzListe[3] + Klasse.Substring(1, Klasse.Length - 1));
            };
            foreach (String Klasse in Klassenstufe9)
            {
                JGKZReferenzListe.Add(JGKlassenstufenReferenzListe[4] + Klasse.Substring(1, Klasse.Length - 1));
            };
            foreach (String Klasse in Klassenstufe10)
            {
                JGKZReferenzListe.Add(JGKlassenstufenReferenzListe[5] + Klasse.Substring(2, Klasse.Length - 2));
            };
            foreach (String Klasse in Profil_11_IB)
            {
                JGKZReferenzListe.Add(JGKlassenstufenReferenzListe[6] + Klasse.Substring(3, Klasse.Length - 3));
            };
            foreach (String Klasse in Profil_11_LuR)
            {
                JGKZReferenzListe.Add(JGKlassenstufenReferenzListe[6] + Klasse.Substring(3, Klasse.Length - 3));
            };
            foreach (String Klasse in Profil_11_WuN)
            {
                JGKZReferenzListe.Add(JGKlassenstufenReferenzListe[6] + Klasse.Substring(3, Klasse.Length - 3));
            };
            foreach (String Klasse in Profil_11_MuK)
            {
                JGKZReferenzListe.Add(JGKlassenstufenReferenzListe[6] + Klasse.Substring(3, Klasse.Length - 3));
            };
            foreach (String Klasse in Profil_12_IB)
            {
                JGKZReferenzListe.Add(JGKlassenstufenReferenzListe[7] + Klasse.Substring(3, Klasse.Length - 3));
            };
            foreach (String Klasse in Profil_12_LuR)
            {
                JGKZReferenzListe.Add(JGKlassenstufenReferenzListe[7] + Klasse.Substring(3, Klasse.Length - 3));
            };
            foreach (String Klasse in Profil_12_WuN)
            {
                JGKZReferenzListe.Add(JGKlassenstufenReferenzListe[7] + Klasse.Substring(3, Klasse.Length - 3));
            };
            foreach (String Klasse in Profil_12_MuK)
            {
                JGKZReferenzListe.Add(JGKlassenstufenReferenzListe[7] + Klasse.Substring(3, Klasse.Length - 3));
            };


        }


    }
}
