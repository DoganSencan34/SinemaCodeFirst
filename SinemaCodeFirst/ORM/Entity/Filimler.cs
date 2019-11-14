using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaCodeFirst.ORM.Entity
{
    public class Filimler
    {
        [Key]//using System.ComponentModel.DataAnnotations eklenir.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int filmID { get; set; }
        public string filmAdi { get; set; }
        public string filmTuru { get; set; }
        public string filmSuresi { get; set; }
        public string filmYönetmeni { get; set; }
        public string filmOyuncular { get; set; }
        public decimal filmImdb { get; set; }
        public string filmGise { get; set; }

        public int AvmId { get; set; }

        public int SalonId { get; set; }

        public virtual Salon Salon { get; set; }

        public virtual Avm  Avm { get; set; }

    }
}
