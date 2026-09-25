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

        // Primary Key
        [Key]
        [Column("id_cita")]
        public int IdCita { get; set; }



        // Campos
        [Column("fecha_cita", TypeName = "date"), Required]
        public DateTime FechaCita { get; set; }


        [Column("motivo", TypeName = "varchar(200)"), MaxLength(200), Required]
        public string Motivo { get; set; }


        [Column("estado_cita", TypeName = "varchar(20)"), MaxLength(20), Required]
        public string EstadoCita { get; set; }



        // Foreing Keys

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


        // RELACIONES


        List<DetalleCita> DetallesCitas { get; set; } = new List<DetalleCita>();
        List<Receta> Recetas { get; set; } = new List<Receta>();

        //Factura Facturas { get; set; } = new Factura();
    }
}
