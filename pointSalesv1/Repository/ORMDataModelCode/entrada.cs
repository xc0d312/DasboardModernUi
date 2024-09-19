using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace pointSalesv1.Models.puntoVenta
{

    public partial class entrada
    {
        public entrada(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
