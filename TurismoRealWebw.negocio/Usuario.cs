using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoRealWebw.DALC;
namespace TurismoRealWebw.negocio
{
    public class Usuario
    {
        public String idUsuario{ get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String email { get; set; }
        public String direccion { get; set; }

        public String  telefono{ get; set; }
        public string idCuentaUsuario { get; set; }

        TurismoRealEntities db = new TurismoRealEntities();
    }
}
