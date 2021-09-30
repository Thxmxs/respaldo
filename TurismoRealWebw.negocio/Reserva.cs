using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoRealWebw.DALC;

namespace TurismoRealWebw.negocio
{
    public class Reserva
    {
        public decimal idReserva { get; set; }
        public DateTime fechaEntrada { get; set; }
        public DateTime fechaSalida { get; set; }
        public String  firmaConformidadCliente{ get; set; }
        public String idUsuario { get; set; }
        public decimal idCheckout { get; set; }
        public Usuario usuario{ get; set; }
        public CuentaUsuario cuentausuario{ get; set; }

        TurismoRealEntities db = new TurismoRealEntities();//nme

        public List<Reserva> ReadAll()
        {
            return this.db.RESERVAs.Select(p => new Reserva() {
            idReserva = p.ID_RESERVA,
            fechaEntrada = (DateTime)p.FECHA_ENTRADA,
            fechaSalida = (DateTime)p.FECHA_SALIDA,
            firmaConformidadCliente = p.FIRMA_CONFORMIDAD_CLIENTE,
            idUsuario = p.USUARIO_ID_USUARIO,
            idCheckout = p.CHECK_OUT_ID_CHECK_OUT,
            usuario = new Usuario()
            {
                idUsuario = p.USUARIO_ID_USUARIO,
                nombre = p.USUARIO.NOMBRE,
                apellido = p.USUARIO.APELLIDO,
                email = p.USUARIO.EMAIL,
                direccion = p.USUARIO.DIRECCION,
                telefono = p.USUARIO.TELEFONO,
                idCuentaUsuario = p.USUARIO.CUENTA_USUARIO_ID_CUENTA_USUARIO
            },

        }).ToList();
        }

    }
}
