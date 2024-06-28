using Annuaire.DAO;
using Annuaire.Context;
using static Annuaire.Context.AnnuaireContext;

namespace AnnuaireAPI
{
    public static class SeedService
    {
        public static void SeedDatabase()
        {
            var factory = new AnnuaireContextFactory();
            using (var context = factory.CreateDbContext([]))
            {


                if (context.Salarie.Any()) return;

                context.Site.Add(new Site() { Id = 1, Ville = "Paris" });
                context.Site.Add(new Site() { Id = 2, Ville = "Nantes" });
                context.Site.Add(new Site() { Id = 3, Ville = "Toulouse" });
                context.Site.Add(new Site() { Id = 4, Ville = "Lille" });
                context.Site.Add(new Site() { Id = 5, Ville = "Nice" });

                context.Service.Add(new Service() { Id = 1, NomService = "Comptabilité" });
                context.Service.Add(new Service() { Id = 2, NomService = "Production" });
                context.Service.Add(new Service() { Id = 3, NomService = "Acceuil" });
                context.Service.Add(new Service() { Id = 4, NomService = "Informatique" });
                context.Service.Add(new Service() { Id = 5, NomService = "Commercial" });
                context.Service.Add(new Service() { Id = 6, NomService = "Relations Humaines" });


                context.Salarie.Add(new Salarie() { Id = 1, Nom = "Dubois", Prenom = "Pierre", TelFix = "0559531010", TelPort = "0626101010", Email = "pierre@dubois.fr", ServiceId = 1, SiteId = 3 });
                context.Salarie.Add(new Salarie() { Id = 2, Nom = "Martin", Prenom = "Jean", TelFix = "0559532020", TelPort = "0626202020", Email = "jean@martin.fr", ServiceId = 2, SiteId = 1 });
                context.Salarie.Add(new Salarie() { Id = 3, Nom = "Durand", Prenom = "Marie", TelFix = "0559533030", TelPort = "0626303030", Email = "marie@durand.fr", ServiceId = 6, SiteId = 2 });
                context.Salarie.Add(new Salarie() { Id = 4, Nom = "Lefebvre", Prenom = "Sophie", TelFix = "0559534040", TelPort = "0626404040", Email = "sophie@lefebvre.fr", ServiceId = 1, SiteId = 3 });
                context.Salarie.Add(new Salarie() { Id = 5, Nom = "Moreau", Prenom = "Luc", TelFix = "0559535050", TelPort = "0626505050", Email = "luc@moreau.fr", ServiceId = 6, SiteId = 1 });
                context.Salarie.Add(new Salarie() { Id = 6, Nom = "Girard", Prenom = "Anne", TelFix = "0559536060", TelPort = "0626606060", Email = "anne@girard.fr", ServiceId = 6, SiteId = 2 });
                context.Salarie.Add(new Salarie() { Id = 7, Nom = "Fournier", Prenom = "Thomas", TelFix = "0559537070", TelPort = "0626707070", Email = "thomas@fournier.fr", ServiceId = 1, SiteId = 3 });
                context.Salarie.Add(new Salarie() { Id = 8, Nom = "Morel", Prenom = "Emma", TelFix = "0559538080", TelPort = "0626808080", Email = "emma@morel.fr", ServiceId = 2, SiteId = 1 });
                context.Salarie.Add(new Salarie() { Id = 9, Nom = "Andre", Prenom = "Paul", TelFix = "0559539090", TelPort = "0626909090", Email = "paul@andre.fr", ServiceId = 3, SiteId = 2 });
                context.Salarie.Add(new Salarie() { Id = 10, Nom = "Leroy", Prenom = "Julie", TelFix = "0559540101", TelPort = "0627001010", Email = "julie@leroy.fr", ServiceId = 6, SiteId = 3 });
                context.Salarie.Add(new Salarie() { Id = 11, Nom = "Roux", Prenom = "Nicolas", TelFix = "0559541111", TelPort = "0627111111", Email = "nicolas@roux.fr", ServiceId = 6, SiteId = 1 });
                context.Salarie.Add(new Salarie() { Id = 12, Nom = "David", Prenom = "Laura", TelFix = "0559542121", TelPort = "0627222121", Email = "laura@david.fr", ServiceId = 6, SiteId = 2 });
                context.Salarie.Add(new Salarie() { Id = 13, Nom = "Thomas", Prenom = "Alexandre", TelFix = "0559543131", TelPort = "0627333131", Email = "alexandre@thomas.fr", ServiceId = 1, SiteId = 3 });
                context.Salarie.Add(new Salarie() { Id = 14, Nom = "Petit", Prenom = "Manon", TelFix = "0559544141", TelPort = "0627444141", Email = "manon@petit.fr", ServiceId = 4, SiteId = 1 });
                context.Salarie.Add(new Salarie() { Id = 15, Nom = "Garcia", Prenom = "Antoine", TelFix = "0559545151", TelPort = "0627555151", Email = "antoine@garcia.fr", ServiceId = 3, SiteId = 2 });
                context.Salarie.Add(new Salarie() { Id = 16, Nom = "Lopez", Prenom = "Camille", TelFix = "0559546161", TelPort = "0627666161", Email = "camille@lopez.fr", ServiceId = 1, SiteId = 3 });
                context.Salarie.Add(new Salarie() { Id = 17, Nom = "Martinez", Prenom = "Hugo", TelFix = "0559547171", TelPort = "0627777171", Email = "hugo@martinez.fr", ServiceId = 4, SiteId = 1 });
                context.Salarie.Add(new Salarie() { Id = 18, Nom = "Lambert", Prenom = "Clara", TelFix = "0559548181", TelPort = "0627888181", Email = "clara@lambert.fr", ServiceId = 5, SiteId = 2 });
                context.Salarie.Add(new Salarie() { Id = 19, Nom = "Richard", Prenom = "Mathis", TelFix = "0559549191", TelPort = "0627999191", Email = "mathis@richard.fr", ServiceId = 1, SiteId = 3 });
                context.Salarie.Add(new Salarie() { Id = 20, Nom = "Tanguy", Prenom = "Inès", TelFix = "0559550202", TelPort = "0627102020", Email = "ines@tanguy.fr", ServiceId = 2, SiteId = 1 });
                context.Salarie.Add(new Salarie() { Id = 21, Nom = "Lecomte", Prenom = "Adam", TelFix = "0559551212", TelPort = "0627212121", Email = "adam@lecomte.fr", ServiceId = 4, SiteId = 2 });
                context.Salarie.Add(new Salarie() { Id = 22, Nom = "Caron", Prenom = "Zoé", TelFix = "0559552222", TelPort = "0627322222", Email = "zoe@caron.fr", ServiceId = 1, SiteId = 3 });
                context.Salarie.Add(new Salarie() { Id = 23, Nom = "Meyer", Prenom = "Louis", TelFix = "0559553232", TelPort = "0627432323", Email = "louis@meyer.fr", ServiceId = 2, SiteId = 1 });
                context.Salarie.Add(new Salarie() { Id = 24, Nom = "Fischer", Prenom = "Léa", TelFix = "0559554242", TelPort = "0627542424", Email = "lea@fischer.fr", ServiceId = 3, SiteId = 2 });
                context.Salarie.Add(new Salarie() { Id = 25, Nom = "Jacquet", Prenom = "Ethan", TelFix = "0559555252", TelPort = "0627652525", Email = "ethan@jacquet.fr", ServiceId = 1, SiteId = 3 });
                context.Salarie.Add(new Salarie() { Id = 26, Nom = "Colin", Prenom = "Chloé", TelFix = "0559556262", TelPort = "0627762626", Email = "chloe@colin.fr", ServiceId = 6, SiteId = 1 });
                context.Salarie.Add(new Salarie() { Id = 27, Nom = "Robin", Prenom = "Noah", TelFix = "0559557272", TelPort = "0627872727", Email = "noah@robin.fr", ServiceId = 6, SiteId = 2 });
                context.Salarie.Add(new Salarie() { Id = 28, Nom = "Blanc", Prenom = "Louise", TelFix = "0559558282", TelPort = "0627982828", Email = "louise@blanc.fr", ServiceId = 5, SiteId = 3 });
                context.Salarie.Add(new Salarie() { Id = 29, Nom = "Guerin", Prenom = "Enzo", TelFix = "0559559292", TelPort = "0627092929", Email = "enzo@guerin.fr", ServiceId = 5, SiteId = 1 });
                context.Salarie.Add(new Salarie() { Id = 30, Nom = "Marchand", Prenom = "Lola", TelFix = "0559560303", TelPort = "0627203030", Email = "lola@marchand.fr", ServiceId = 5, SiteId = 2 });
                context.Salarie.Add(new Salarie() { Id = 31, Nom = "Roy", Prenom = "Nathan", TelFix = "0559561313", TelPort = "0627313131", Email = "nathan@roy.fr", ServiceId = 5, SiteId = 3 });
                context.Salarie.Add(new Salarie() { Id = 32, Nom = "Barbier", Prenom = "Jade", TelFix = "0559562323", TelPort = "0627423232", Email = "jade@barbier.fr", ServiceId = 2, SiteId = 1 });
                context.Salarie.Add(new Salarie() { Id = 33, Nom = "Perrin", Prenom = "Tom", TelFix = "0559563333", TelPort = "0627533333", Email = "tom@perrin.fr", ServiceId = 5, SiteId = 2 });
                context.Salarie.Add(new Salarie() { Id = 34, Nom = "Dupont", Prenom = "Eva", TelFix = "0559564343", TelPort = "0627643434", Email = "eva@dupont.fr", ServiceId = 1, SiteId = 3 });
                context.Salarie.Add(new Salarie() { Id = 35, Nom = "Gauthier", Prenom = "Théo", TelFix = "0559565353", TelPort = "0627753535", Email = "theo@gauthier.fr", ServiceId = 1, SiteId = 1 });
                context.Salarie.Add(new Salarie() { Id = 36, Nom = "Roussel", Prenom = "Manon", TelFix = "0559566363", TelPort = "0627863636", Email = "manon@roussel.fr", ServiceId = 1, SiteId = 2 });
                context.Salarie.Add(new Salarie() { Id = 37, Nom = "Chevalier", Prenom = "Mathéo", TelFix = "0559567373", TelPort = "0627973737", Email = "matheo@chevalier.fr", ServiceId = 5, SiteId = 3 });
                context.Salarie.Add(new Salarie() { Id = 38, Nom = "Boyer", Prenom = "Léa", TelFix = "0559568383", TelPort = "0627083838", Email = "lea@boyer.fr", ServiceId = 5, SiteId = 1 });
                context.Salarie.Add(new Salarie() { Id = 39, Nom = "Huet", Prenom = "Léo", TelFix = "0559569393", TelPort = "0627193939", Email = "leo@huet.fr", ServiceId = 4, SiteId = 2 });
                context.Salarie.Add(new Salarie() { Id = 40, Nom = "Michel", Prenom = "Romane", TelFix = "0559570404", TelPort = "0627304040", Email = "romane@michel.fr", ServiceId = 4, SiteId = 3 });
                context.Salarie.Add(new Salarie() { Id = 41, Nom = "Leclerc", Prenom = "Mathys", TelFix = "0559571414", TelPort = "0627414141", Email = "mathys@leclerc.fr", ServiceId = 4, SiteId = 1 });
                context.Salarie.Add(new Salarie() { Id = 42, Nom = "Vidal", Prenom = "Sarah", TelFix = "0559572424", TelPort = "0627524242", Email = "sarah@vidal.fr", ServiceId = 4, SiteId = 2 });
                context.Salarie.Add(new Salarie() { Id = 43, Nom = "Fernandez", Prenom = "Nolan", TelFix = "0559573434", TelPort = "0627634343", Email = "nolan@fernandez.fr", ServiceId = 4, SiteId = 3 });
                context.Salarie.Add(new Salarie() { Id = 44, Nom = "Philippe", Prenom = "Agathe", TelFix = "0559574444", TelPort = "0627744444", Email = "agathe@philippe.fr", ServiceId = 4, SiteId = 1 });
                context.Salarie.Add(new Salarie() { Id = 45, Nom = "Leroux", Prenom = "Maxime", TelFix = "0559575454", TelPort = "0627854545", Email = "maxime@leroux.fr", ServiceId = 4, SiteId = 2 });
                context.Salarie.Add(new Salarie() { Id = 46, Nom = "Bourgeois", Prenom = "Eva", TelFix = "0559576464", TelPort = "0627964646", Email = "eva@bourgeois.fr", ServiceId = 4, SiteId = 3 });
                context.Salarie.Add(new Salarie() { Id = 47, Nom = "Renard", Prenom = "Lucas", TelFix = "0559577474", TelPort = "0627074747", Email = "lucas@renard.fr", ServiceId = 4, SiteId = 1 });
                context.Salarie.Add(new Salarie() { Id = 48, Nom = "Lefevre", Prenom = "Lina", TelFix = "0559578484", TelPort = "0627184848", Email = "lina@lefevre.fr", ServiceId = 4, SiteId = 2 });
                context.Salarie.Add(new Salarie() { Id = 49, Nom = "Clement", Prenom = "Mathéo", TelFix = "0559579494", TelPort = "0627294949", Email = "matheo@clement.fr", ServiceId = 4, SiteId = 3 });
                context.Salarie.Add(new Salarie() { Id = 50, Nom = "Morin", Prenom = "Inès", TelFix = "0559580505", TelPort = "0627405050", Email = "ines@morin.fr", ServiceId = 5, SiteId = 1 });
                context.Salarie.Add(new Salarie() { Id = 51, Nom = "Gonzalez", Prenom = "Arthur", TelFix = "0559581515", TelPort = "0627515151", Email = "arthur@gonzalez.fr", ServiceId = 5, SiteId = 2 });
                context.Salarie.Add(new Salarie() { Id = 52, Nom = "Ferreira", Prenom = "Louise", TelFix = "0559582525", TelPort = "0627625252", Email = "louise@ferreira.fr", ServiceId = 5, SiteId = 3 });
                context.Salarie.Add(new Salarie() { Id = 53, Nom = "Leroux", Prenom = "Léo", TelFix = "0559583535", TelPort = "0627735353", Email = "leo@leroux.fr", ServiceId = 5, SiteId = 1 });
                context.Salarie.Add(new Salarie() { Id = 54, Nom = "Rousseau", Prenom = "Léa", TelFix = "0559584545", TelPort = "0627845454", Email = "lea@rousseau.fr", ServiceId = 6, SiteId = 2 });
                context.Salarie.Add(new Salarie() { Id = 55, Nom = "Perez", Prenom = "Thomas", TelFix = "0559585555", TelPort = "0627955555", Email = "thomas@perez.fr", ServiceId = 6, SiteId = 3 });
                context.Salarie.Add(new Salarie() { Id = 56, Nom = "Gauthier", Prenom = "Mélissa", TelFix = "0559586565", TelPort = "0627065656", Email = "melissa@gauthier.fr", ServiceId = 6, SiteId = 1 });
                context.Salarie.Add(new Salarie() { Id = 57, Nom = "Fontaine", Prenom = "Sacha", TelFix = "0559587575", TelPort = "0627175757", Email = "sacha@fontaine.fr", ServiceId = 2, SiteId = 2 });
                context.Salarie.Add(new Salarie() { Id = 58, Nom = "Poulain", Prenom = "Léna", TelFix = "0559588585", TelPort = "0627285858", Email = "lena@poulain.fr", ServiceId = 1, SiteId = 3 });
                context.Salarie.Add(new Salarie() { Id = 59, Nom = "Lemoine", Prenom = "Maxime", TelFix = "0559589595", TelPort = "0627395959", Email = "maxime@lemoine.fr", ServiceId = 2, SiteId = 1 });
                context.SaveChanges();
            }

        }
    }
}
