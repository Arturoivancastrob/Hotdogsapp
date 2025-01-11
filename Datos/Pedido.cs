using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{

    [Table("Pedidos")]
    public class Pedido

    {
        [Key]
        public int PedidoID { get; set; }

        [Required, ForeignKey("FK_Pedidos_Usuarios_Id")]
        public int UsuarioID { get; set; }

        [MaxLength(50)]
        public DateTime FechaPedido { get; set; }

        [Required, MaxLength(50)]
        public string Estado { get; set; }

        [Required, MaxLength(100)]
        public string TipoEntrega { get; set; }

        [Required, MaxLength(100)]
        public decimal Total { get; set; }



       
        [NotMapped]
        public Usuario Usuario { get; set; }

        [NotMapped]
        public ICollection<DetallePedidos> DetallesPedido { get; set; }

        [NotMapped]
        public Pago Pago { get; set; }
    }
}
