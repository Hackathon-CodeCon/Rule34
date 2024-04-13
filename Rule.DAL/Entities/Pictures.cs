using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Rule.DAL.Entities
{
    public class Pictures
    {
        [Key, Column(TypeName = "tinyint")]
        public int Id { get; set; }
        public required byte[] Picture { get; set; }
    }
}
