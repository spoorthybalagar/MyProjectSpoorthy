using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OurHeroAPIWithCodeFirstApproch.Models
{
    [Table("tblOurHeros")]
    public class OurHero
    {
        [Key]
        public int? Id { get; set; }
        //[Key]
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public bool isActive { get; set; }
    }
}
