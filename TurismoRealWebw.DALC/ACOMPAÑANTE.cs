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
    
    public partial class ACOMPAÑANTE
    {
        public ACOMPAÑANTE()
        {
            this.USUARIOs = new HashSet<USUARIO>();
        }
    
        public decimal ID_ACOMPAÑANTE { get; set; }
        public string NOMBRE_ACOMPAÑANTE { get; set; }
        public string APELLIDO_ACOMPAÑANTE { get; set; }
    
        public virtual ICollection<USUARIO> USUARIOs { get; set; }
    }
}
