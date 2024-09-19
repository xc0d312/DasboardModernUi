using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using pointSalesv1.Models.puntoVenta;

namespace pointSalesv1.ObjValues
{
    public class validationModelsVenta : AbstractValidator<venta>
    {
        public validationModelsVenta()
        {
            RuleFor(d => d.total).NotEmpty().NotNull();
            RuleFor(d => d.id_cliente).NotEmpty();
            RuleFor(d => d.id_usuario).NotEmpty();
        }
    }
}
