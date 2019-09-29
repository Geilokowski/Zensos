﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zensos.Helper;
using Zensos.Objects;

namespace Zensos
{
    public partial class FrmMain : Form
    {
        List<TSchueler> _StudentList = new List<TSchueler>();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (txtPath.Text.Equals(""))
            {
                if (excelFileDialog.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private static List<TSchueler> getStudentList()
        {
            List<TSchueler> studentList = new List<TSchueler>();
            TSchueler SEintrag = new TSchueler(
                2015 // Aufnahmejahr
                , 2023 // Abschlussjahrgang
                , "JG16s" // Jahrgang KZ
                , "10s" // Klasse
                , "Thomas Wendland" // Geburtsname
                , "von zu Wéndländ - Märkenstein" // Name
                , "Thömás" // Vorname
                , false // Geschlecht
                , "04.12.1959" // Geburtsdatumn
                );
            studentList.Add(SEintrag);

            SEintrag = new TSchueler(
                2015 // Aufnahmejahr
                , 2023 // Abschlussjahrgang
                , "JG15LuR2" // Jahrgang KZ
                , "10s" // Klasse
                , "Adrian Lübke" // Geburtsname
                , "Lübke" // Name
                , "Adrian" // Vorname
                , false // Geschlecht
                , "04.12.1959" // Geburtsdatumn
                );
            studentList.Add(SEintrag);

            SEintrag = new TSchueler(
                2015 // Aufnahmejahr
                , 2023 // Abschlussjahrgang
                , "JG15LuR" // Jahrgang KZ
                , "11-LuR2" // Klasse
                , "Phillip" // Geburtsname
                , "Goose" // Name
                , "Philippine" // Vorname
                , false // Geschlecht
                , "04.12.1959" // Geburtsdatumn
                );
            studentList.Add(SEintrag);

            SEintrag = new TSchueler(
                2015 // Aufnahmejahr
                , 2023 // Abschlussjahrgang
                , "JG16b" // Jahrgang KZ
                , "11-LuR" // Klasse
                , "Eric Runge" // Geburtsname
                , "Eric" // Name
                , "Runge" // Vorname
                , false // Geschlecht
                , "04.12.1959" // Geburtsdatumn
                );
            studentList.Add(SEintrag);

            SEintrag = new TSchueler(
                2015 // Aufnahmejahr
                , 2023 // Abschlussjahrgang
                , "JG15s" // Jahrgang KZ
                , "11-LuR" // Klasse
                , "Johann Goose" // Geburtsname
                , "Goose" // Name
                , "Johann" // Vorname
                , false // Geschlecht
                , "04.12.1959" // Geburtsdatumn
                );
            studentList.Add(SEintrag);

            return studentList;
        }

        private void btnGenerateStudents_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Generating students...");
            _StudentList = getStudentList();
            Console.WriteLine("Students generated successfully");

            Console.WriteLine();
        }

        private void btnShowClasses_Click(object sender, EventArgs e)
        {
            List<String> classList = new List<string>();
            classList = StudentHelper.getCurrentClasses(_StudentList);
            Console.WriteLine("The following " + classList.Count + " class(es) exist this year:");
            ConsoleHelper.OutputStr(classList);

            Console.WriteLine();
        }

        private void btnGenerateJGKZ_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Generating JGKZ for " + _StudentList.Count + " students...");
            List<String> classList = StudentHelper.getJGKZsForStudents(_StudentList);
            Console.WriteLine("JGKZ generated successfully");
            ConsoleHelper.OutputStr(_StudentList, classList);
        }

        private void btnSortAfterClass_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Students sorted after their Class: ");
            ConsoleHelper.OutputSortedListAfterClass(SortHelper.bubbleSortClass(_StudentList));
        }

        private void btnSortAfterJGKZ_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Students sorted after their JGKZ: ");
            ConsoleHelper.OutputSortedListAfterJGKZ(SortHelper.bubbleSortJGKZ(_StudentList));
        }

        private void btnSortAfterName_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Students sorted after their Name: ");
            ConsoleHelper.OutputSortedListAfterName(SortHelper.bubbleSortName(_StudentList));
        }

        private void btnSortAfterClassAndName_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Students sorted after their class an then their Name: ");
            ConsoleHelper.OutputSortedListAfterClass(SortHelper.bubbleSortClassAndName(_StudentList));
        }

        private void btnOutputStudents_Click(object sender, EventArgs e)
        {
            Console.WriteLine("The following students exist: ");
            ConsoleHelper.OutputStudents(_StudentList);
        }
    }
}