using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoRealWebw.DALC;

namespace TurismoRealWebw.negocio
{
    public class CuentaUsuario
    {
        public String idCuentaUsuario { get; set; }
        public decimal idTipoUsuario { get; set; }
        public String emailUsuario { get; set; }

        public String passwordUsuario { get; set; }

        public DateTime fechaCreacion { get; set; }

        TurismoRealEntities db = new TurismoRealEntities();

       // public List<CuentaUsuario> ReadAll()
        //{
          // return this.db.CUENTA_USUARIO.Select<>
        //}
    }
}
