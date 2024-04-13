using Rule.DAL.Entities;
using System.ComponentModel.DataAnnotations;

namespace Rule.BL.Models
{
    public class PostsDTO
    {
        public int Id { get; set; }
        [Required, MaxLength(200)]
        public string Name { get; set; }
        [Required, MaxLength(1500)]
        public string Description { get; set; }
        public int? FinishSum { get; set; }
        [Required]
        public DateTime CreationTime { get; set; }
        public Users Users { get; set; }
        public int? StatusPostId { get; set; }
        public int? TypePostId { get; set; }
        public string? Link { get; set; }
        public Foundations Foundations { get; set; }
        [Required]
        public byte[] PicturesPosts { get; set; }
    }
}
