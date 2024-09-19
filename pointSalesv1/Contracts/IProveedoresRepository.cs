using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointSalesv1.Contracts
{
   public interface IProveedoresRepository
    {
        bool existProveedores(string name);
    }
}
