using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica
{
    [Table("consultorios")]
    public class Consultorio
    {
        // Primary Key
        [Key]
        [Column("id_consultorio")]
        public int IdConsultorio { get; set; }


        // Campos
        [Column("numero_sala"), MaxLength(10), Required]
        public string NumeroSala { get; set; }


        [Column("piso"), Required]
        public int Piso { get; set; }


        [Column("equipamiento_principal"), MaxLength(100), Required]
        public string EquipamientoPrincipal { get; set; }


        // Relaciones

        List<Cita> Citas { get; set; } = new List<Cita>();

    }
}
