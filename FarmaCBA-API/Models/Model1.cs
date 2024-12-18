using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication1.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<CLIENTES> CLIENTES { get; set; }
        public virtual DbSet<DISPENSACIONES> DISPENSACIONES { get; set; }
        public virtual DbSet<FACTURAS> FACTURAS { get; set; }
        public virtual DbSet<FACTURAS_TIPOS_PAGOS> FACTURAS_TIPOS_PAGOS { get; set; }
        public virtual DbSet<PERSONAL> PERSONAL { get; set; }
        public virtual DbSet<PERSONAL_CARGOS_ESTABLECIMIENTOS> PERSONAL_CARGOS_ESTABLECIMIENTOS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.APELLIDO)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.CALLE)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.NRO_DOC)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .HasMany(e => e.FACTURAS)
                .WithRequired(e => e.CLIENTES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DISPENSACIONES>()
                .Property(e => e.DESCUENTO)
                .HasPrecision(10, 2);

            modelBuilder.Entity<DISPENSACIONES>()
                .Property(e => e.PRECIO_UNITARIO)
                .HasPrecision(10, 2);

            modelBuilder.Entity<DISPENSACIONES>()
                .Property(e => e.MATRICULA)
                .IsUnicode(false);

            modelBuilder.Entity<DISPENSACIONES>()
                .Property(e => e.CODIGO_VALIDACION)
                .IsUnicode(false);

            modelBuilder.Entity<FACTURAS>()
                .HasMany(e => e.DISPENSACIONES)
                .WithRequired(e => e.FACTURAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FACTURAS>()
                .HasMany(e => e.FACTURAS_TIPOS_PAGOS)
                .WithRequired(e => e.FACTURAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FACTURAS_TIPOS_PAGOS>()
                .Property(e => e.PORCENTAJE_PAGO)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PERSONAL>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONAL>()
                .Property(e => e.APELLIDO)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONAL>()
                .Property(e => e.CALLE)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONAL>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONAL>()
                .Property(e => e.NRO_DOC)
                .IsUnicode(false);

            modelBuilder.Entity<PERSONAL>()
                .HasMany(e => e.PERSONAL_CARGOS_ESTABLECIMIENTOS)
                .WithRequired(e => e.PERSONAL)
                .WillCascadeOnDelete(false);
        }
    }
}
