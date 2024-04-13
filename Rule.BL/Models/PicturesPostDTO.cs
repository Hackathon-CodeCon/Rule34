using System.ComponentModel.DataAnnotations;

namespace Rule.BL.Models
{
    public class PicturesPostDTO
    {
        public int Id { get; set; }
        [Required]
        public byte[] Picture { get; set; }
    }
}
