using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace Journals_Tests
{
    class Navigation_Elements
    {
        private Navigation_Elements() { }

        public static List<string> GetExternalElements()
        {
            List<string> externalElements = new List<string>();
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"D:\Responsive-Batch-5.xlsx");

            foreach (var journal in Journals.GetNamesOfJournals())
            {
                Excel._Worksheet xlWorksheet = xlWorkbook.Worksheets[Journals.GetNamesOfJournals().Count];
                Excel.Range xlRange = xlWorksheet.UsedRange;
                int rowIndex = xlRange.Rows.Count;
                int colIndex = xlRange.Columns.Count;

                for (int j = 1; j <= rowIndex; j++) //колонки
                {
                    if (xlRange.Cells[2, j].Value != null && xlRange.Cells[2, j].Value2 != null)
                    {
                        externalElements.Add(xlRange.Cells[2, j].Value2);
                    }
                }
            }

            return externalElements;
        }

        public static List<string> GetInternalElements()
        {
            List<string> internalElements = new List<string>();
            foreach (var journal in Journals.GetNamesOfJournals())
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"D:\Responsive-Batch-5.xlsx");
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[journal];
                Excel.Range xlRange = xlWorksheet.UsedRange;
                int rowIndex = xlRange.Rows.Count;
                int colIndex = xlRange.Columns.Count;
                for (int j = 1; j <= rowIndex; j++)
                {
                    for (int i = 3; i <= colIndex; i++)
                    {
                        if (xlRange.Cells[i, j].Value != null && xlRange.Cells[i, j].Value2 != null)
                        {
                            internalElements.Add(xlRange.Cells[i, j].Value2);
                        }
                    }
                }

            }
            return internalElements;
        }
    }
}
