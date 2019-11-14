using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaCodeFirst.ORM.Entity
{
    public class AvmHasilat
    {
        [Key]//using System.ComponentModel.DataAnnotations eklenir.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HasilatID{ get; set; }
        public string AvmID { get; set; }
        public string Bakiye { get; set; }

        public List<Avm> Avms { get; set; }
    }
}
