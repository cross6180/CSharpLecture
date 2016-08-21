using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace BikeOrdering
{
    public class ExcelView : IView
    {
        private static ExcelView excel = new ExcelView();
        private OrderManagement orderManagement;

        private Excel.Workbook ordersBook = null;
        private Excel.Application ordersApp = null;
        private Excel.Worksheet ordersSheet = null;
        private string filePath = "C:\\Users/User/Dropbox/CsharpLecture/FinalProject/BikeOrders.xls";
        private object missing = System.Reflection.Missing.Value;

        private ExcelView()
        {
            this.orderManagement = OrderManagement.GetOrderManagement();
            orderManagement.Register(this);

            ordersApp = new Excel.Application();
            ordersApp.Visible = false;
            if (!System.IO.File.Exists(@filePath)) //File doesn't exist
            {
                ordersBook = ordersApp.Workbooks.Add(Missing.Value);
                ordersSheet = ordersBook.Worksheets.get_Item(1);

                // Setting cell values
                ((Excel.Range)ordersSheet.Cells[1, "A"]).Value2 = "訂單編號";
                ((Excel.Range)ordersSheet.Cells[1, "B"]).Value2 = "姓名";
                ((Excel.Range)ordersSheet.Cells[1, "C"]).Value2 = "電話";
                ((Excel.Range)ordersSheet.Cells[1, "D"]).Value2 = "價錢";
                ((Excel.Range)ordersSheet.Cells[1, "E"]).Value2 = "車身顏色";
                ((Excel.Range)ordersSheet.Cells[1, "F"]).Value2 = "籃子顏色";
                ((Excel.Range)ordersSheet.Cells[1, "G"]).Value2 = "鎖的種類";
                ((Excel.Range)ordersSheet.Cells[1, "H"]).Value2 = "橫/斜桿";
                ((Excel.Range)ordersSheet.Cells[1, "I"]).Value2 = "數量";

                ordersBook.SaveAs(filePath, Excel.XlFileFormat.xlWorkbookNormal, missing, missing,
                    false, false, Excel.XlSaveAsAccessMode.xlExclusive, missing, missing, missing, missing, missing);
            }
            else
            {
                ordersBook = ordersApp.Workbooks.Open(filePath);
                ordersSheet = (Excel.Worksheet)ordersBook.Sheets[1]; // Explicit cast is not required here
            }

            //ordersBook.Close();
            //ordersApp.Quit();
        }

        public static ExcelView GetExcelView()
        {
            return excel;
        }

        public void UpdateView()
        {
            int cnt = 1;
            foreach (OneCompleteOrder order in this.orderManagement.Orders)
            {
                //string cellName = "A" + cnt.ToString();
                //var range = ordersSheet.get_Range(cellName, cellName);
                //range.Value2 = order.ToString();
                //++cnt;
            }

            //ordersBook = ordersApp.Workbooks.Open(filePath);
            //ordersApp.DisplayAlerts = false;
            //ordersBook.SaveAs(filePath, Excel.XlFileFormat.xlWorkbookNormal, missing, missing,
            //     false, false, Excel.XlSaveAsAccessMode.xlExclusive, missing, missing, missing, missing, missing);

            //ordersBook.Close();
        }
    }
}