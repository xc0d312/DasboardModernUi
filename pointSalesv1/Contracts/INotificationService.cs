using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointSalesv1.Models.puntoVenta;

namespace pointSalesv1.Contracts
{
    interface INotificationService
    {
        void notifyLowStock<T>(T p, int stock) where T : productos;
    }
}
