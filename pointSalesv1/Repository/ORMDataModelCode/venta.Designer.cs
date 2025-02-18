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

    public partial class venta : XPLiteObject
    {
        long fidVenta;
        [Key(true)]
        public long idVenta
        {
            get { return fidVenta; }
            set { SetPropertyValue<long>(nameof(idVenta), ref fidVenta, value); }
        }
        string fcodigo;
        [Size(6)]
        public string codigo
        {
            get { return fcodigo; }
            set { SetPropertyValue<string>(nameof(codigo), ref fcodigo, value); }
        }
        DateTime ffecha;
        public DateTime fecha
        {
            get { return ffecha; }
            set { SetPropertyValue<DateTime>(nameof(fecha), ref ffecha, value); }
        }
        double ftotal;
        public double total
        {
            get { return ftotal; }
            set { SetPropertyValue<double>(nameof(total), ref ftotal, value); }
        }
        clientes fid_cliente;
        [Association(@"ventaReferencesclientes")]
        public clientes id_cliente
        {
            get { return fid_cliente; }
            set { SetPropertyValue<clientes>(nameof(id_cliente), ref fid_cliente, value); }
        }
        usuarios fid_usuario;
        [Association(@"ventaReferencesusuarios")]
        public usuarios id_usuario
        {
            get { return fid_usuario; }
            set { SetPropertyValue<usuarios>(nameof(id_usuario), ref fid_usuario, value); }
        }
        estado fid_estado;
        [Association(@"ventaReferencesestado")]
        public estado id_estado
        {
            get { return fid_estado; }
            set { SetPropertyValue<estado>(nameof(id_estado), ref fid_estado, value); }
        }
        [Association(@"detalle_ventaReferencesventa")]
        public XPCollection<detalle_venta> detalle_ventas { get { return GetCollection<detalle_venta>(nameof(detalle_ventas)); } }
    }

}
