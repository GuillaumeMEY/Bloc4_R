using Annuaire.DAO;
using AnnuaireModel.Dao;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace Annuaire.Context
{
    public class AnnuaireContext(DbContextOptions<AnnuaireContext> options) : IdentityDbContext<User>(options)
    {
        public DbSet<Salarie> Salarie { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Site> Site { get; set; }
        public DbSet<User> User { get; set; }


        public class AnnuaireContextFactory : IDesignTimeDbContextFactory<AnnuaireContext>
        {
            public AnnuaireContext CreateDbContext(string[] args)
            {
                var connexionString = "server=localhost;port=3306;userid=root;password=;database=AnnuaireBloc4_R;";
                var optionsBuilder = new DbContextOptionsBuilder<AnnuaireContext>();
                optionsBuilder.UseMySql(connexionString, ServerVersion.AutoDetect(connexionString));

                return new AnnuaireContext(optionsBuilder.Options);
            }
        }


    }




}
