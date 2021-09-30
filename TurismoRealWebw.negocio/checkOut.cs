using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoRealWebw.DALC;

namespace TurismoRealWebw.negocio
{
    public class checkOut
    {
        public decimal idCheckOut { get; set; }
        public String estadoHabitacion { get; set; }
        public decimal multa { get; set; }
        public decimal costoReparacion { get; set; }
        public String descripcion { get; set; }

        TurismoRealEntities db = new TurismoRealEntities();
    }
    
}
    
