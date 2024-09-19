using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointSalesv1.Contracts
{
    public interface IProductsRepository
    {
        bool existProdStock(string name);
    }
}
