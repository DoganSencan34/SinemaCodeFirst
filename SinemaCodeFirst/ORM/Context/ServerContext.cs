using SinemaCodeFirst.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaCodeFirst.ORM.Context
{
    public class ServerContext:DbContext
    {
        public ServerContext()
        {
            Database.Connection.ConnectionString = "Server=.;Database=SinemaProje;uid=sa;pwd=1234;";
        }

        public DbSet<Avm> Avms { get; set; }
        public DbSet<Filimler> Filimlers { get; set; }
        public DbSet<Salon> Salons { get; set; }
        public DbSet<Koltuk> Koltuks { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<AvmHasilat> AvmHasilats { get; set; }
    }
}
