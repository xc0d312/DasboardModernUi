using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointSalesv1.ObjValues
{
    public class transactionMath
    {
        public int countReCords<T>(IEnumerable<T> lst)
        {
            return lst.Count();
        }
        public decimal mountTotal<T>(T costo, T cantidad) where T : new()
        {
            var resul = Convert.ToDecimal(costo) * Convert.ToInt32(cantidad);
            return resul;
        }
    }
}
