using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    [Table("DireccioneEnvio")]
    public class DirecciónEnvio
    {
        [Key]
        public int DireccionID { get; set; }

        [Required, ForeignKey("FK_DireccionEnvio_Usuarios_Id")]
        public int UsuarioID { get; set; }

        [Required, MaxLength(300)]
        public string Direccion { get; set; }

        [MaxLength(50)]
        public string Ciudad { get; set; }


        [Required, MaxLength(50)]
        public string CodigoPostal { get; set; }

        [NotMapped]
        public Usuario Usuario { get; set; }
    }
}
