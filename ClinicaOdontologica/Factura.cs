using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica
{
    [Table("facturas")]
    public class Factura
    {

        [Key]
        [Column("id_factura")]
        public int IdFactura { get; set; }



        [Column("fecha_emision"), Required]
        public DateOnly FechaEmision { get; set; }



        [Column("subtotal", TypeName = ("numeric(10, 2)")), Required]
        public decimal Subtotal { get; set; }



        [Column("impuestos", TypeName = ("numeric(10, 2)")), Required]
        public decimal Impuestos { get; set; }


        [Column("total", TypeName = ("numeric(10, 2)")), Required]
        public decimal Total { get; set; }

        [Column("estado_pago"), MaxLength(20), Required]
        public string EstadoPago { get; set; }




        [ForeignKey("Cita")]
        [Column("id_cita")]
        public int IdCita { get; set; }
        public Cita? Cita { get; set; }



    }
}
