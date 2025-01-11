using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [EmailAddress]
        public string Correo { get; set; }

        [Required, MaxLength(200)]
        public string Contraseña { get; set; }
        
        [Required, MaxLength(15)]
        public string Telefono { get; set; }
        
        [Required, MaxLength(200)]
        public string Direccion { get; set; }
        
        [MaxLength(200)]
        public DateTime FechaRegistro { get; set; }

        [MaxLength(15)]
        public string Tipo { get; set; }

        [NotMapped]
        public ICollection<Pedido> Pedidos { get; set; }
    }
}