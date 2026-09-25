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
        // Primary key
        [Key]
        [Column("id_especialidad")]
        public int IdEspecialidad { get; set; }


        //  CAMPOS

        [Column("descripcion", TypeName = "varchar(200)"), MaxLength(200), Required]
        public string Descripcion { get; set; }


        [Column("nombre_especialidad", TypeName = "varchar(50)"), MaxLength(50), Required]
        public string NombreEspecialidad { get; set; }


        // RELACIONES
        List<Odontologo> Odontologos { get; set; } = new List<Odontologo>();


    }
}
