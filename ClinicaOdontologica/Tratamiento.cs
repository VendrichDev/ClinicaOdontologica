using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica
{
    [Table("tratamientos")]
    public class Tratamiento
    {

        [Key]
        [Column("id_tratamiento")]
        public int IdTratamiento { get; set; }


        [Column("nombre_tratamiento", TypeName = "varchar(100)"), MaxLength(100), Required]
        public string NombreTratamiento { get; set; }

        [Column("costo_base", TypeName = "numeric(10, 2)"), Required]
        public decimal CostoBase { get; set; }


        [Column("duracion_estimada_minutos"), Required]
        public int DuracionEstimadaMinutos { get; set; }


        List<DetalleCita> DetallesCita { get; set; } = new List<DetalleCita>();


    }
}
