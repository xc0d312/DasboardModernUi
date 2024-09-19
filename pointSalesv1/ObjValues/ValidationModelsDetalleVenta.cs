using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using pointSalesv1.Models.puntoVenta;

namespace pointSalesv1.ObjValues
{
    public class validationModelsDetalleVenta : AbstractValidator<detalle_venta>
    {
        public validationModelsDetalleVenta()
        {
            RuleFor(d => d.precioUnitario).GreaterThan(0);
            RuleFor(d => d.id_prod).NotNull();
            RuleFor(d => d.costoUnitario).GreaterThan(0);
            RuleFor(d => d.id_prod.stock).GreaterThan(0);
        }

    }
}
