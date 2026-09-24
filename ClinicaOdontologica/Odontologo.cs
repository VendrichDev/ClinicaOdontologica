using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica
{
    [Table("odontologos")]
    public class Odontologo
    {

        [Key]
        [Column("id_odontologo")]
        public int IdOdontologo { get; set; }



        [ForeignKey("Especialidad")]
        [Column("id_especialidad")]
        public int IdEspecialidad { get; set; }
        public Especialidad? Especialidad { get; set; }


        [Column("registro_medico"), MaxLength(20), Required]
        public string RegistroMedico { get; set; }


        [Column("nombre"), MaxLength(50), Required]
        public string Nombre { get; set; }

        [Column("apellido"), MaxLength(50), Required]
        public string Apellido { get; set; }


        // Relaciones

        //Especialidad Especialidades { get; set; } = new Especialidad();
        List<Cita> Citas { get; set; } = new List<Cita>();

    }
}
