using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica
{
    [Table("historialesmedicos")]

    public class HistorialMedico
    {

        [Key]
        [Column("id_historial")]
        public int IdHistorial { get; set; }



        [ForeignKey("Paciente")]
        [Column("id_paciente")]
        public int IdPaciente { get; set; }
        public Paciente? Paciente { get; set; }


        [Column("tipo_sangre", TypeName = "varchar(5)"), MaxLength(5)]
        public string TipoSangre { get; set; }


        [Column("alergias", TypeName = "varchar(200)"), MaxLength(200)]
        public string Alergias { get; set; }


        [Column("enfermedades_previas", TypeName = "varchar(200)"), MaxLength(200)]
        public string EnfermedadesPrevias { get; set; }


        // RELACIONES

        //Paciente Pacientes { get; set; } = new Paciente();

    }
}
