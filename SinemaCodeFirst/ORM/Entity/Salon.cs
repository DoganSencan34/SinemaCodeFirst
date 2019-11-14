using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaCodeFirst.ORM.Entity
{
    public class Salon
    {
        [Key]//using System.ComponentModel.DataAnnotations eklenir.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int salonID { get; set; }
        public string salonNo { get; set; }
        public string salonSeans { get; set; }
        public string salonKapasite { get; set; }

        public int filmId { get; set; }
       // public int avmId { get; set; }

        public virtual Koltuk Koltuk { get; set; }

        //public List<Avm> Avms { get; set; }
        public List<Filimler> Filimlers { get; set; }


    }
}
