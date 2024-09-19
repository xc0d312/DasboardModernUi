using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointSalesv1.Models
{
    public class listGanancias
    {
        public string codigo { get; set; }
        public DateTime fecha { get; set; }
        public string cliente { get; set; }
        public string producto { get; set; }
        public Double montoTotal { get; set; }
        public Double gananciasTotales { get; set; }
    }
}
