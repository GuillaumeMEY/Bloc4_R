using Annuaire.DAO;
using Microsoft.EntityFrameworkCore;


namespace Annuaire.Context
{
    public class AnnuaireContext : DbContext
    {
        public DbSet<Salarie> Salarie { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Site> Site { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connexionString = "server=localhost;port=3306;userid=root;password=;database=AnnuaireBloc4_R;";
            optionsBuilder.UseMySql(connexionString, ServerVersion.AutoDetect(connexionString));
        }

    }




}
