using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Rule.BL.Models
{
    public class FoundationsDTO
    {
        public int Id { get; set; }
        [Required, MaxLength(1500)]
        public string Description { get; set; }
        [Required]
        public string Link { get; set; }

        public ICollection<PicturesDTO>? Pictures { get; set; }
    }
}
