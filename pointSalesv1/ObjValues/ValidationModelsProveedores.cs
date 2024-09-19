using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointSalesv1.Contracts;
using pointSalesv1.Models.puntoVenta;
using pointSalesv1.Repository;
using FluentValidation;
using pointSalesv1.Views;

namespace pointSalesv1.ObjValues
{
    public class ValidationModelsProveedores:AbstractValidator<proveedores>
    {
        IProveedoresRepository objModels;

        public ValidationModelsProveedores()
        {
            objModels = new RegistroProveedores();
            RuleFor(d => d.empresa).MustAsync(async (done, cancel) =>
            {
                bool exist = await existProveedor(done);
                return !exist;
            }).WithMessage("Ya existe este proveedor");
            RuleFor(d => d.empresa).NotEmpty().NotNull();
            RuleFor(d => d.empresa).Length(4, 60);
            RuleFor(d => d.razon).NotEmpty().NotNull();
            RuleFor(d => d.direccion).NotEmpty().NotNull();
            RuleFor(d => d.direccion).Length(10, 90);
            RuleFor(d => d.telefono).NotEmpty().NotNull();
            RuleFor(d => d.telefono).Length(1, 10);
        }
        private async Task<bool> existProveedor(string name)
        {
            bool resul = true;
            await Task.Run(() =>
            {
                resul = objModels.existProveedores(name) ? true : false;
            });
            return resul;
        }
    }
}
