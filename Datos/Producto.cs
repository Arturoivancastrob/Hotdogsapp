using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    [Table("Productos")]
    public class Producto
    {
        [Key]
        public int ProductoID { get; set; }
        
        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required, MaxLength(200)]
        public string Descripcion { get; set; }

        [Required, MaxLength(50)]
        public decimal Precio { get; set; }

        [Required, MaxLength(50)]
        public string Categoria { get; set; }

        [Required, MaxLength(50)]
        public bool Disponible { get; set; }


        [NotMapped]
        public ICollection<DetallePedidos> DetallesPedidos { get; set; }
    }
}
