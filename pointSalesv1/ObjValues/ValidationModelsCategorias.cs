using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using pointSalesv1.Contracts;
using pointSalesv1.Models.puntoVenta;

namespace pointSalesv1.ObjValues
{
    public  class ValidationModelsCategorias: AbstractValidator<categoria>
    {
        ICategoriaRepository objModels;
        public ValidationModelsCategorias()
        {
            objModels = new CategoriasForm();
            RuleFor(d => d.nombre).MustAsync(async (done, cancel) =>
            {
                bool exist = await existCategoria(done);
                return !exist;
            }).WithMessage("Ya existe esta categoria");
            RuleFor(d => d.nombre).NotEmpty().NotNull();
            RuleFor(d => d.nombre).Length(10, 60);
            RuleFor(d => d.descripcion).NotEmpty().NotNull();
            RuleFor(d => d.descripcion).Length(10, 60);

        }
        private async Task<bool> existCategoria(string nameCategoria)
        {
            bool resul = true;
            await Task.Run(() =>
            {
                resul = objModels.existCategoria(nameCategoria) ? true : false;
            });
            return resul;
        }
    }
}
