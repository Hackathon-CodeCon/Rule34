using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Rule.DAL.Entities
{
    public class Posts
    {
        [Key, Column(TypeName = "tinyint")]
        public int Id { get; set; }
        [Column(TypeName = "text"), MaxLength(1500)]
        public required string Description { get; set; }
        public int? FinishSum {  get; set; }
        [DataType(DataType.Date)]
        public required DateTime CreationTime { get; set; }
        public int UsersId { get; set; }
        public virtual Users Users { get; set; }
        public int StatusPostId { get; set; }
        public virtual StatusPost StatusPost { get; set; }
        public int TypePostId {  get; set; }
        public virtual TypePost TypePost { get; set; }
        public string? Link { get; set; }
        public int FoundationsId {  get; set; }
        public virtual Foundations Foundations { get; set; }

        public required ICollection<PicturesPost> PicturesPosts { get; set; }
    }
}
