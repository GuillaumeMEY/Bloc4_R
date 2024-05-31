using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnnuaireModel.Dao
{
    public class User : IdentityUser
    {
    [Required]
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Identifiant")]
        public string Identifiant { get; set; }

        [Column("Mdp")]
        public string Mdp { get; set; }
    }

}

