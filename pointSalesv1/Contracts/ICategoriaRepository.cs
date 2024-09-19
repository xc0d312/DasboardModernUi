using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointSalesv1.Contracts
{
    interface ICategoriaRepository
    {
        bool existCategoria(string name);
    }
}
