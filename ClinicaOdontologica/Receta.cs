using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica
{
    [Table("recetas")]
    public class Receta
    {

        [Key]
        [Column("id_receta")]
        public int IdReceta { get; set; }


        [Column("fecha_emision"), Required]
        public DateTime FechaEmision { get; set; }


        [Column("indicaciones"), Required]
        public string Indicaciones { get; set; }



        [ForeignKey("Cita")]
        [Column("id_cita")]
        public int IdCita { get; set; }
        public Cita? Cita { get; set; }

        // Relaciones

        //Cita Citas { get; set; } = new Cita();

    }
}
