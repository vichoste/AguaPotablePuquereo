//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AguaPotablePuquereo.Models.SQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_DEUDA
    {
        public int DEU_ID { get; set; }
        public int MES_ID { get; set; }
        public int DEU_PERIODO_ANO { get; set; }
        public System.DateTime DEU_PERIODO_VENCE { get; set; }
        public int DEU_DEUDA { get; set; }
        public Nullable<int> CLI_ID { get; set; }
        public Nullable<int> PAG_ID { get; set; }
        public bool DEU_CHECK { get; set; }
    
        public virtual TBL_CLIENTE TBL_CLIENTE { get; set; }
        public virtual TBL_MES TBL_MES { get; set; }
        public virtual TBL_PAGOS TBL_PAGOS { get; set; }
    }
}
