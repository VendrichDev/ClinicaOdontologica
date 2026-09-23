using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica
{
    [Table("especialidades")]
    public class Especialidad
    {

        [Key]
        [Column("id_especialidad")]
        public int idEspecialidad { get; set; }


        [Column("descripcion"), MaxLength(200), Required]
        public string Descripcion { get; set; }


        [Column("nombre_especialidad"), MaxLength(50), Required]
        public string NombreEspecialidad { get; set; }
    }
}
