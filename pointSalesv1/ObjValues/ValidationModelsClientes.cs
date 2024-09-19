using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using pointSalesv1.Models.puntoVenta;
using pointSalesv1.Contracts;
using pointSalesv1.Views;

namespace pointSalesv1.ObjValues
{
    public class ValidationModelsClientes:AbstractValidator<clientes>
    {
        IClientesRepository objModels; 
       public ValidationModelsClientes()
        {
            objModels = new RegistroClientes();
            RuleFor(d => d.dni).MustAsync(async (done, cancel) =>
            {
                bool exist = await existCliente(done);
                return !exist;
            }).WithMessage("Ya existe este cliente");
            RuleFor(d => d.nombre).MaximumLength(60);
            RuleFor(d => d.nombre).NotEmpty().NotNull();
            RuleFor(d => d.telefono).NotEmpty().NotNull();
            RuleFor(d => d.telefono).MaximumLength(10);
            //RuleFor(d => d.email).NotEmpty().NotNull();
            //RuleFor(d => d.email).MaximumLength(90);
            //RuleFor(d => d.email).EmailAddress();
            RuleFor(d => d.direccion).NotEmpty().NotNull();
            RuleFor(d => d.direccion).MaximumLength(90);
            //RuleFor(d => d.sexo).NotEmpty().NotNull();
        }
        private async Task<bool> existCliente(string dni)
        {
            bool resul = true;
            await Task.Run(() =>
            {
                resul = objModels.existClient(dni) ? true : false;
            });
            return resul;
        }
    }
}
