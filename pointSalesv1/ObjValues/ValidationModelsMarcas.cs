using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointSalesv1.Contracts;
using pointSalesv1.Models.puntoVenta;
using FluentValidation;
using pointSalesv1.Views;

namespace pointSalesv1.ObjValues
{
    public class ValidationModelsMarcas:AbstractValidator<marcas>
    {
        IMarcasRepository objModels;
       public ValidationModelsMarcas()
        {
            objModels = new MarcasForm();
            RuleFor(d => d.marcas1).MustAsync(async (done, cancel) =>
            {
                bool exist = await existMarcas(done);
                return !exist;
            }).WithMessage("Ya existe esta marca");
            RuleFor(d => d.marcas1).NotEmpty().NotNull();
            RuleFor(d => d.marcas1).Length(3, 90);
            RuleFor(d => d.descripcion).NotEmpty().NotNull();
            RuleFor(d => d.descripcion).Length(3, 90);
        }
        private async Task<bool> existMarcas(string nameMarcas)
        {
            bool resul = true;
            await Task.Run(() =>
            {
                resul = objModels.existMarcas(nameMarcas)?true:false;

            });
            return resul;
        }

    }
}
