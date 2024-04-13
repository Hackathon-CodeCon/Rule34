using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Rule.BL.Models
{
    public class UsersDTO
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string? Name { get; set; }
        [MaxLength(50)]
        public string? LastName { get; set; }
        [MaxLength(100)]
        public string? Username { get; set; }
        public int? Phone { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        public ICollection<PostsDTO>? Posts { get; set; }
        public ICollection<PicturesDTO>? Pictures { get; set; }
    }
}
