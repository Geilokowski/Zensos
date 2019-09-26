using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Zensos.Helper
{
    class ExcelHelper
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Sheets sheets;

        public ExcelHelper(string path)
        {
            try
            {
                this.path = path;
                wb = excel.Workbooks.Open(path);
                sheets = wb.Sheets;
            }
            catch (COMException e)
            {
                if (Statics.printStacktrace)
                    Console.WriteLine(e.ToString());

                throw new Exceptions.TableNotFoundException(path);
            }
        }

        public int getRowCount(int sheet)
        {
            sheet++;
            _Excel.Range usedRange = sheets[sheet].UsedRange;
            return usedRange.Rows.Count;
        }

        public string ReadCell(int sheet, int row, int column)
        {
            row++;
            column++;
            sheet++;
            if (sheets[sheet].Cells[row, column].Value == null)
                return null;
            else
                return sheets[sheet].Cells[row, column].Value.ToString();
        }

        public string ReadCell(Worksheet sheet, int row, int column)
        {
            row++;
            column++;
            if(sheet.Cells[row, column].Value == null)
                return null;
            else
                return sheet.Cells[row, column].Value.ToString();
        }

        public int getWorksheetCount()
        {
            return wb.Worksheets.Count;
        }

        public List<List<List<string>>> getContentOld()
        {
            List<List<List<string>>> worksheets = new List<List<List<string>>>();
            foreach (Worksheet sheet in sheets)
            {
                //Console.WriteLine("Sheet: " );
                //Console.WriteLine("Rows : " + sheet.UsedRange.Rows.Count);
                List<List<string>> rows = new List<List<string>>();
                int column = 0;
                string currentValue = "";
                for (int row = 0; row < sheet.UsedRange.Rows.Count; row++)
                {
                    List<string> columns = new List<string>();
                    while (currentValue != null)
                    {
                        currentValue = ReadCell(sheet, row, column);
                        if (currentValue != null)
                        {
                            columns.Add(currentValue);
                        }
                        column++;
                    }

                    currentValue = "";
                    column = 0;
                    List<string> tmpList = new List<string>(columns);
                    rows.Add(tmpList);
                    columns.Clear();
                }

                List<List<String>> newList = new List<List<String>>(rows);
                worksheets.Add(newList);
                rows.Clear();
            }

            return worksheets;
        }

        public List<List<List<string>>> getContent()
        {
            List<List<List<string>>> worksheets = new List<List<List<string>>>();
            for (int sheet = 0; sheet < wb.Sheets.Count; sheet++)
            {
                worksheets.Add(new List<List<string>>());
                int column = 0;
                string currentValue = "";
                for (int row = 0; row < sheets[sheet + 1].UsedRange.Rows.Count; row++)
                {
                    worksheets.Last().Add(new List<string>());
                    while (currentValue != null)
                    {
                        currentValue = ReadCell(sheet, row, column);
                        if (currentValue != null)
                        {
                            worksheets.Last().Last().Add(currentValue);
                        }
                        column++;
                    }

                    currentValue = "";
                    column = 0;
                }
            }

            return worksheets;
        }

    }
}
