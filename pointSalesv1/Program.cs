using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using pointSalesv1;
using DevExpress.Data;
using DevExpress.Xpo;
using pointSalesv1.Models.puntoVenta;
using pointSalesv1.Messages;
using pointSalesv1.Views;

namespace pointSalesv1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
       {
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(
               ConnectionHelper.ConnectionString,
               DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema
           );
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DashboardForm());
        }
    }
}
