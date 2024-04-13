using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rule.DAL.Entities
{
    public class Users
    {
        [Key, Column(TypeName = "tinyint")]
        public int Id { get; set; }
        [MaxLength(50)]
        public string? Name { get; set; }
        [MaxLength(50)]
        public string? LastName { get; set; }
        [MaxLength(100)]
        public string? Username { get; set;}
        public int? Phone { get; set;}
        public string? Email { get; set; }

        public ICollection<Posts>? Posts { get; set; }
        public ICollection<Pictures>? Pictures { get; set; }
    }
}
