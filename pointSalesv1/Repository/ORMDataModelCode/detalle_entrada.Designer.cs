﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace pointSalesv1.Models.puntoVenta
{

    public partial class detalle_entrada : XPLiteObject
    {
        int fidDetalle;
        [Key(true)]
        public int idDetalle
        {
            get { return fidDetalle; }
            set { SetPropertyValue<int>(nameof(idDetalle), ref fidDetalle, value); }
        }
        entrada fid_entrada;
        [Association(@"detalle_entradaReferencesentrada")]
        public entrada id_entrada
        {
            get { return fid_entrada; }
            set { SetPropertyValue<entrada>(nameof(id_entrada), ref fid_entrada, value); }
        }
        productos fid_prod;
        [Association(@"detalle_entradaReferencesproductos")]
        public productos id_prod
        {
            get { return fid_prod; }
            set { SetPropertyValue<productos>(nameof(id_prod), ref fid_prod, value); }
        }
        double fcosto;
        public double costo
        {
            get { return fcosto; }
            set { SetPropertyValue<double>(nameof(costo), ref fcosto, value); }
        }
        int fcantidad;
        public int cantidad
        {
            get { return fcantidad; }
            set { SetPropertyValue<int>(nameof(cantidad), ref fcantidad, value); }
        }
        double fprecio;
        public double precio
        {
            get { return fprecio; }
            set { SetPropertyValue<double>(nameof(precio), ref fprecio, value); }
        }
        tipounidad ftipoUnidad;
        [Association(@"detalle_entradaReferencestipounidad")]
        public tipounidad tipoUnidad
        {
            get { return ftipoUnidad; }
            set { SetPropertyValue<tipounidad>(nameof(tipoUnidad), ref ftipoUnidad, value); }
        }
    }

}
