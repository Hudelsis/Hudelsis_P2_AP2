using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hudelsis_P2_AP2.Models
{
    public class Cobros
    {
        [Key]
        public int CobroId { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public int Totales { get; set; }
        public float Cobro { get; set; }
        public string Observacion { get; set; }

        [ForeignKey("CobroId")]
        public virtual List<CobrosDetalle> cobrosDetalle { get; set; } = new List<CobrosDetalle>();

    }
}
