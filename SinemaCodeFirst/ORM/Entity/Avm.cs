using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaCodeFirst.ORM.Entity
{
    public class Avm
    {
        [Key]//using System.ComponentModel.DataAnnotations eklenir.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AvmID { get; set; }
        public string AvmAdi { get; set; }
        public string AvmAdres { get; set; }
        public string AvmTelefon { get; set; }
        public string WebAdres { get; set; }

        public virtual AvmHasilat Hasilat { get; set; }
        public List<Filimler> Filimler { get; set; }
    }
}
