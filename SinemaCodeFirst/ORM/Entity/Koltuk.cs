using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaCodeFirst.ORM.Entity
{
    public class Koltuk
    {
        [Key]//using System.ComponentModel.DataAnnotations eklenir.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int koltukID { get; set; }

        public int koltukNo { get; set; }

        public int salonId { get; set; }

        public List<Salon> Salons { get; set; }
    }
}
