//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TurismoRealWebw.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class PAGO
    {
        public decimal ID_PAGO { get; set; }
        public string FORMA_PAGO { get; set; }
        public Nullable<decimal> MONTO_PAGO { get; set; }
        public Nullable<System.DateTime> FECHA_PAGO { get; set; }
        public decimal ESTADO_PAGO_ID_ESTADO_PAGO { get; set; }
        public decimal RESERVA_ID_RESERVA { get; set; }
    
        public virtual ESTADO_PAGO ESTADO_PAGO { get; set; }
        public virtual RESERVA RESERVA { get; set; }
    }
}