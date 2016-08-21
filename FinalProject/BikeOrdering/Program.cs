using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeOrdering
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            OrderManagement orderManagement = OrderManagement.GetOrderManagement();
            //orderManagement.Register(ExcelView.GetExcelView());
            BikeOrder order = new BikeOrder();
            UserController controller = new UserController(order);
            Application.Run(controller.view as BikeOrderingForm);

            //ManagerController mController = new ManagerController();
            //Application.Run(mController.view as OrderManagementForm);
        }
    }
}