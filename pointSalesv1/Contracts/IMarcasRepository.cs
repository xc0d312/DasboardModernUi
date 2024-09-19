using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointSalesv1.Contracts
{
   public interface IMarcasRepository
    {
        bool existMarcas(string nameMarcas);
    }
}
