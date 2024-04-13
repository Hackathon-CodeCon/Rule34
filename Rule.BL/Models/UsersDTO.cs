using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Rule.BL.Models
{
    public class UsersDTO
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; } 
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        [Required, MaxLength(100)]
        public string Username { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required,DataType(DataType.Password)]
        public string Password { get; set; }

        public ICollection<PostsDTO>? Posts { get; set; }
        public ICollection<PicturesDTO>? Pictures { get; set; }
    }
}
