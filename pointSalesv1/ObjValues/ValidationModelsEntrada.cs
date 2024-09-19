using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointSalesv1.Cache;
using pointSalesv1.Contracts;
using pointSalesv1.Models.puntoVenta;
using FluentValidation;

namespace pointSalesv1.ObjValues
{
   public class ValidationModelsEntrada:AbstractValidator<entrada>
    {
       public ValidationModelsEntrada()
        {
            RuleFor(d => d.total).GreaterThan(0);
            RuleFor(d => d.id_proveedor).NotNull();
            RuleForEach(d => d.detalle_entradas).SetValidator(new ValidationModelsDetalleEntrada());
        }
    }
}
