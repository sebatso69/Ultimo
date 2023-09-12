using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador.Models
{
    public class SimuladorDbContext : DbContext
    {
        public SimuladorDbContext() : base("name=Simulador")
        {
        }

        public DbSet<APIToken> APITokens { get; set; }
        public DbSet<Condicion_Beneficio> Condicion_Beneficios { get; set; }
        public DbSet<Beneficio> Beneficios { get; set; }
        public DbSet<Condicion> Condicion { get; set; }
        public DbSet<Simulacion_Cond> Simulacion_Cond { get; set; }
        public DbSet<Simulacion> Simulacion { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //DESCOMENTAR -> Add-Migration -> updatedb -> Ejecutar insert sin identity -> COMENTAR NUEVAMENTE -> Add-Migration -> updatedb -> fin
            //modelBuilder.Entity<NombreEntidad>().Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);base.OnModelCreating(modelBuilder);
        }
    }
}
