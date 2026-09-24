using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica
{
    [Table("pacientes")]
    public class Paciente
    {

        [Key]
        [Column("id_paciente")]
        public int IdPaciente { get; set; }


        [Column("dni"), MaxLength(10), Required]
        public string Dni { get; set; }


        [Column("nombres"), MaxLength(50), Required]
        public string Nombres { get; set; }


        [Column("apellidos"), MaxLength(50), Required]
        public string Apellidos { get; set; }


        [Column("fecha_nacimiento"), Required]
        public DateOnly FechaNacimiento { get; set; }


        [Column("email"), EmailAddress, Required, MaxLength(100)]
        public string Email { get; set; }


        [Column("telefono"), Phone, MaxLength(15), Required]
        public string Telefono { get; set; }

        // Relaciones
        List<Cita> Citas { get; set; } = new List<Cita>();

        //HistorialMedico HistorialesPaciente { get; set; } = new HistorialMedico();

    }
}
