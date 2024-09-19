using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointSalesv1.Contracts;
using pointSalesv1.ObjValues;
using pointSalesv1.Repository;
using pointSalesv1.Models.puntoVenta;
using FluentValidation;

namespace pointSalesv1.ObjValues
{
   public class ValidationModelsDetalleEntrada:AbstractValidator<detalle_entrada>
    {
       public ValidationModelsDetalleEntrada()
        {
            RuleFor(d => d.id_prod).NotNull().WithMessage("Producto es requerido");
            //RuleFor(d => d.id_entrada).NotNull().WithMessage("");
            RuleFor(d => d.costo).GreaterThan(0);
            RuleFor(d => d.cantidad).GreaterThan(0);
            //  RuleFor(d =>d.id_entrada).NotNull().SetValidator(new validationModelsEntrada());
            //RuleFor(d => d.id_entrada).ChildRules(entrada => {
            //    entrada.RuleFor(d => d.id_proveedor).NotNull().WithMessage("Proveedor es requerido");
            //    entrada.RuleFor(d => d.total).GreaterThan(0);
            //});
        }
    }
}
