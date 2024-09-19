using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace pointSalesv1.Models.puntoVenta
{

    public partial class detalle_perdida
    {
        public detalle_perdida(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
