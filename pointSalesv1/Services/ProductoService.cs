using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointSalesv1.Contracts;
using DevExpress.Xpo;
using pointSalesv1.Repository.ORMDataModelCode;
using pointSalesv1.Models.puntoVenta;

namespace pointSalesv1.Services
{
    class ProductoService : INotificationService
    {
        public event Action<productos, int> lowStockNotification;
        public void notifyLowStock<T>(T p, int stock) where T : productos
        {
            lowStockNotification?.Invoke(p, stock);
        }
    }
}
