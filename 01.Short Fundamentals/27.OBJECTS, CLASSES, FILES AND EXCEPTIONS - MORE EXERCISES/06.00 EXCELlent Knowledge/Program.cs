using System;
using MyExcel = Microsoft.Office.Interop.Excel;

namespace P06_EXCELlentKnowledge
{
    class P06_EXCELlentKnowledge
    {
        static void Main() // 100/100
        {
            var xlsApp = new MyExcel.Application();
            var xlsWorkbook = xlsApp.Workbooks.Open(@"C:\Users\me\Documents\PF-2017\01.Short Fundamentals\27.OBJECTS, CLASSES, FILES AND EXCEPTIONS - MORE EXERCISES\sample_table.xlsx");
            var xlsSheet = xlsWorkbook.Sheets[1];
            var range = xlsSheet.UsedRange;

            var columnsCount = range.Columns.Count;
            var rowsCount = range.Rows.Count;

            for (int i = 1; i <= rowsCount; i++)
            {
                for (int j = 1; j <= columnsCount; j++)
                {
                    if (range.Cells[i, j] == null || range.Cells[i, j].Value2 == null)
                    {
                        goto Break;
                    }
                    Console.Write((range.Cells[i, j].Value2.ToString()) + "|");
                }
                Console.WriteLine();
            }
            Break:

            xlsWorkbook.Close();
            xlsApp.Quit();
        }
    }
}


/* Output to paste in judge.softuni.bg
ZIP|Sales|Name|Year|Value|
2121|456|Jane|2011|84219|
2092|789|Ashish|2012|28322|
2128|456|Jane|2013|81878|
2073|123|John|2011|44491|
*/
