using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using pointSalesv1.Models.puntoVenta;

namespace pointSalesv1.ObjValues
{
    public class ValidationModelsUsers:AbstractValidator<usuarios>
    {
        public ValidationModelsUsers()
        {
            RuleFor(d => d.userName).NotEmpty().NotNull();
            RuleFor(d => d.userName).Length(3, 40);
            RuleFor(d => d.password).NotEmpty().NotNull();
            RuleFor(d => d.password).Length(8, 50);
            RuleFor(d => d.rol).NotEmpty().NotNull();
            RuleFor(d => d.rol).MaximumLength(40);
            RuleFor(d => d.fullName).NotEmpty();
        }
    }

}
