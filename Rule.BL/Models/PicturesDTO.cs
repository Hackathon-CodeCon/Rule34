using System.ComponentModel.DataAnnotations;

namespace Rule.BL.Models
{
    public class PicturesDTO
    {
        public int Id { get; set; }
        [Required]
        public byte[] Picture { get; set; }
    }
}
