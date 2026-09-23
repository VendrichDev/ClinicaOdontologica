using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica
{
    [Table("citas")]
    public class Cita
    {

        [Key]
        [Column("id_cita")]
        public int IdCita { get; set; }


        [Column("fecha_cita"), Required]
        public DateOnly FechaCita { get; set; }


        [Column("motivo"), MaxLength(200), Required]
        public string Motivo { get; set; }


        [Column("estado_cita"), MaxLength(20), Required]
        public string EstadoCita { get; set; }



        [ForeignKey("Paciente")]
        [Column("id_paciente")]
        public int IdPaciente { get; set; }
        public Paciente? Paciente { get; set; }


        [ForeignKey("Odontologo")]
        [Column("id_odontologo")]
        public int IdOdontologo { get; set; }
        public Odontologo? Odontologo { get; set; }


        [ForeignKey("Consultorio")]
        [Column("id_consultorio")]
        public int IdConsultorio { get; set; }
        public Consultorio? Consultorio { get; set; }

    }
}
