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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TurismoRealEntities : DbContext
    {
        public TurismoRealEntities()
            : base("name=TurismoRealEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ACOMPAÑANTE> ACOMPAÑANTE { get; set; }
        public DbSet<CHECK_OUT> CHECK_OUT { get; set; }
        public DbSet<CHECKLIST_ESTADO_INVENTARIO> CHECKLIST_ESTADO_INVENTARIO { get; set; }
        public DbSet<COMUNA> COMUNAs { get; set; }
        public DbSet<CONDUCTOR> CONDUCTORs { get; set; }
        public DbSet<CONTRATO> CONTRATOes { get; set; }
        public DbSet<CUENTA_USUARIO> CUENTA_USUARIO { get; set; }
        public DbSet<DEPARTAMENTO> DEPARTAMENTOes { get; set; }
        public DbSet<ESTADO_PAGO> ESTADO_PAGO { get; set; }
        public DbSet<IMPUESTO> IMPUESTOes { get; set; }
        public DbSet<MANTENCION> MANTENCIONs { get; set; }
        public DbSet<OBJETO_HABITACION> OBJETO_HABITACION { get; set; }
        public DbSet<PAGO> PAGOes { get; set; }
        public DbSet<PROVEEDOR> PROVEEDORs { get; set; }
        public DbSet<PROVINCIA> PROVINCIAs { get; set; }
        public DbSet<REGION> REGIONs { get; set; }
        public DbSet<RESERVA> RESERVAs { get; set; }
        public DbSet<SERVICIO> SERVICIOs { get; set; }
        public DbSet<TIPO_USUARIO> TIPO_USUARIO { get; set; }
        public DbSet<TOUR> TOURs { get; set; }
        public DbSet<TRANSPORTE> TRANSPORTEs { get; set; }
        public DbSet<USUARIO> USUARIOs { get; set; }
        public DbSet<VEHICULO> VEHICULOes { get; set; }
    }
}
