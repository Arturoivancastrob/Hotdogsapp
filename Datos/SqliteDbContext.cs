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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Db/Hotdogsapp.sqlite");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetallePedidos> DetallesPedidos { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<DirecciónEnvio> DireccionesEnvio { get; set; }

        public SqliteDbContext(DbContextOptions<SqliteDbContext> options)
            : base(options)
        { }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<DetallePedidos>()
                .HasOne(dp => dp.Pedido)
                .WithMany(p => p.DetallesPedido)
                .HasForeignKey(dp => dp.PedidoID);

            modelBuilder.Entity<DetallePedidos>()
                .HasOne(dp => dp.Producto)
                .WithMany(p => p.DetallesPedidos)
                .HasForeignKey(dp => dp.ProductoID);
        }
    }
}
