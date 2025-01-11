using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Datos
{
    public class SqliteDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetallePedidos> DetallesPedidos { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<DirecciónEnvio> DireccionesEnvio { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Hotdogsapp.sqlite");
        }

        public SqliteDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración de relaciones
            modelBuilder.Entity<DetallePedidos>()
                .HasOne(dp => dp.Pedido)
                .WithMany(p => p.DetallesPedido)
                .HasForeignKey(dp => dp.PedidoID);

            modelBuilder.Entity<DetallePedidos>()
                .HasOne(dp => dp.Producto)
                .WithMany(p => p.DetallesPedidos)
                .HasForeignKey(dp => dp.ProductoID);

            // Data Seeding: Insertar productos iniciales
            modelBuilder.Entity<Producto>().HasData(
                new Producto { ProductoID = 1, Nombre = "Hot Dog", Precio = 60m, Categoria = "Comida" },
                new Producto { ProductoID = 2, Nombre = "Hot Dog Especial", Precio = 75m, Categoria = "Comida" },
                new Producto { ProductoID = 3, Nombre = "Salchipapas", Precio = 65m, Categoria = "Comida" }
            );
        }
    }
}