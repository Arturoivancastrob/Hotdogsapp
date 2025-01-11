using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    [Table("DetallePedidos")]
    public class DetallePedidos

    {
        [Key]
        public int DetalleID { get; set; }

        [Required, ForeignKey("FK_DetallePedidos_Pedidos_Id")]
        public int PedidoID { get; set; }

        [Required, ForeignKey("FK_DetallePedidos_Productos_Id")]
        public int ProductoID { get; set; }

        [Required, MaxLength(50)]
        public int Cantidad { get; set; }

        [Required, MaxLength(50)]
        public decimal PrecioUnitario { get; set; }

        [Required, MaxLength(50)]
        public decimal Total { get; set; }

        [NotMapped]
        public Pedido Pedido { get; set; }

        [NotMapped]
        public Producto Producto { get; set; }
    }
}

