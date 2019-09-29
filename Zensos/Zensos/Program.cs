using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zensos.Helper;

namespace Zensos
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());

            return;

            TSchueler SEintrag = new TSchueler(
                2015 // Aufnahmejahr
                , 2023 // Abschlussjahrgang
                , "JG15s" // Jahrgang KZ
                , "9s" // Klasse
                , "Thomas Wendland" // Geburtsname
                , "von zu Wéndländ - Märkenstein" // Name
                , "Thömás" // Vorname
                , false // Geschlecht
                , "04.12.1959" // Geburtsdatumn
                );

            try
            {
                Console.WriteLine("Reading Excel file...");
                ExcelHelper excel = new ExcelHelper("C:\\Users\\Adrian\\source\\repos\\Geilokowski\\Zensos\\Zensos\\Zensos\\SchuelerGymnasium.xls");
                Console.WriteLine("File successfully read...");

                Console.WriteLine("Cell 0/0: " + excel.ReadCell(0, 0, 0));
                Console.WriteLine("Total of " + excel.getRowCount(0) + " rows found");

                List<List<List<string>>> content  = excel.getContent();
                Console.WriteLine("Sheet Count: " + content.Count);
                Console.WriteLine("Row Count  : " + content[0].Count);
                Console.WriteLine("Cell 0/0   : " + content[0][0][0]);
            }
            catch (Exceptions.TableNotFoundException e)
            {
                Console.WriteLine("Error: Excel Table not Found at path: " + e.getPath());
            }

            if (!Helper.Statics.debug)
            {
                Console.WriteLine("Schülerdaten:");
                Console.WriteLine("Geburtsname: " + SEintrag.GeburtsName);
                Console.WriteLine("Name: " + SEintrag.Name);
                Console.WriteLine("Vorname: " + SEintrag.Vorname);
                Console.WriteLine("geboren am: " + SEintrag.GeburtsDatum.ToShortDateString());
                Console.WriteLine("Geburtstag: " + SEintrag.Geburtstag.ToShortDateString());
                Console.WriteLine("UserNameID " + SEintrag.UserNameID);
                Console.WriteLine("Alter: " + SEintrag.Alter);
                Console.WriteLine("Aufnahme " + SEintrag.AufnahmeJahrgang);
                Console.WriteLine("Abi-Jahrgang " + SEintrag.AbschlussJahrgang);
                Console.WriteLine("Jahrgang " + SEintrag.JahrgangKZ);
                Console.WriteLine("Klasse " + SEintrag.Klasse);

                TKlassenUebersicht TKU = new TKlassenUebersicht();
                Console.WriteLine("Schuljahr " + TKU.AktuellesSchuljahr);
                Console.WriteLine("AufnahmeJahr " + TKU.ReferenzJahr.ToString());
                Console.WriteLine("Klassenstufe 5 : " + TKU.Klassenstufe5[0]);
                Console.WriteLine("Klassenstufe 6 : " + TKU.GrundStufe[1][0]);
                Console.WriteLine("Klassenstufe 10 : " + TKU.SekundarStufe1[3][0]);
                Console.WriteLine("Klassenstufe 11 : " + TKU.SekundarStufe2[0][1]);
                Console.WriteLine("Klassenstufe 12 : " + TKU.SekundarStufe2[1][1]);
                Console.WriteLine("JGKZReferenz Klassenstufe 12 : " + TKU.JGKlassenstufenReferenzListe[7]);
                Console.WriteLine("Test : " + TKU.Klassenstufe8.IndexOf("8b"));

                Console.WriteLine("Klassenreferenz: ");
                foreach (String Klasse in TKU.KlassenReferenzListe)
                    Console.WriteLine("Klasse : " + Klasse);

                Console.WriteLine("Jahrgang der Klassenstufe 5-12 : ");
                foreach (String Jahrgang in TKU.JGKlassenstufenReferenzListe)
                    Console.WriteLine("JGKZ : " + Jahrgang);

                Console.WriteLine("JGKZ der Klassen: ");
                foreach (String Klasse in TKU.JGKZReferenzListe)
                    Console.WriteLine("JGKZ : " + Klasse);
            }

            Console.ReadKey();
        }
    }
}
