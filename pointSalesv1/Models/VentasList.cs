using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointSalesv1.Models
{
    public class VentasList
    {
        //public int idVentas { get; set; }
        public string codigo { get; set;}
        public DateTime fechaVenta { get; set; }
        public string cliente { get; set; }
        public string producto { get; set; }
        public Double montoTotal { get; set; }
    }
}
