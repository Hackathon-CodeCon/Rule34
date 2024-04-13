using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule.DAL.Entities
{
    public class Pictures
    {
        [Key, Column(TypeName = "tinyint")]
        public int Id { get; set; }
        public required byte[] Picture { get; set; }
    }
}
