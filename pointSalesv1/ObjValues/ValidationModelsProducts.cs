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
    public class ValidationModelsProducts:AbstractValidator<productos>
    {
        IProductsRepository objModels;
       public ValidationModelsProducts()
        {
            //instance class product
            objModels = new ProductosForm();
            //Rules validating fields
            RuleFor(d => d.nombre).MustAsync(async (done, cancel) =>
            {
                bool exist = await existProd(done);
                return !exist;
            }).WithMessage("Ya existe este producto");
            RuleFor(d => d.nombre).NotEmpty();
            RuleFor(d => d.nombre).Length(10, 90);
            RuleFor(d => d.id_marcas).NotEmpty();
            RuleFor(d => d.id_categoria).NotEmpty();
            RuleFor(d => d.id_estado).NotEmpty();
            RuleFor(d => d.stock).NotEmpty();
            RuleFor(d => d.stock).LessThan(100);
            RuleFor(d => d.precio).NotEmpty();
        }
        private async Task<bool> existProd(string nameProd)
        {
            bool resul = true;
            await Task.Run(() =>
            {
                resul = true ? objModels.existProdStock(nameProd) : false;
            });
            return resul;
        }
    }
}
