using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using System;

namespace Journals_Tests
{
    class Journals
    {
        private Journals() { } 
        public  static List<string> GetNamesOfJournals()
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"D:\Responsive-Batch-5.xlsx");
            int numberOfJournals = xlWorkbook.Sheets.Count;

            List<string> journals = new List<string>();

            for (int journal = 1; journal <= numberOfJournals; journal++)
            {
                journals.Add(xlWorkbook.Sheets[journal].Name); 
            }

            return journals;
        }
    }
}
