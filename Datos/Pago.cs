using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    [Table("Pagos")]
    public class Pago

    {
        [Key]
        public int PagoID { get; set; }

        [Required, ForeignKey("FK_Pagos_Pedidos_Id")]
        public int PedidoID { get; set; }

        [Required, MaxLength(50)]
        public decimal Monto { get; set; }


        [MaxLength(50)]
        public DateTime FechaPago { get; set; }

        [Required, MaxLength(100)]
        public string MetodoPago { get; set; }

        [MaxLength(50)]
        public string EstadoPago { get; set; }

        [NotMapped]
        public Pedido Pedido { get; set; }
    }
}

