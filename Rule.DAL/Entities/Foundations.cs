using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule.DAL.Entities
{
    public class Foundations
    {
        [Key, Column(TypeName = "tinyint")]
        public int Id { get; set; }
        [Column(TypeName = "text"), MaxLength(1500)]
        public required string Description { get; set; }
        public required string Link { get; set; }

        public ICollection<Pictures>? Pictures { get; set; }
    }
}
