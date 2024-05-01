using System.ComponentModel.DataAnnotations.Schema;

namespace Annuaire.DAO
{
    public class Salarie
    {

        public int Id { get; set; }

        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public string TelFix { get; set; } = string.Empty;
        public string TelPort { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;


        [ForeignKey(nameof(Service))]
        public int ServiceId { get; set; }
        public virtual Service Service { get; set; } = null!;


        [ForeignKey(nameof(Site))]
        public int SiteId { get; set; }
        public virtual Site Site { get; set; } = null!;

    }
}
