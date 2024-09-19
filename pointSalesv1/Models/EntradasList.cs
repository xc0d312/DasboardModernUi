using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointSalesv1.Models
{
    public class EntradasList
    {
        public int idEntrada { get; set; }
        public DateTime fechaEntrada { get; set; }
        public string proveedor { get; set; }
        public string productos { get; set; }
        public Double montoTotal { get; set; }
    }
}
