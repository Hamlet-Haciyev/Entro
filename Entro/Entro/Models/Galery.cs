using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entro.Models
{
    public class Galery
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [Column(TypeName ="ntext")]
        public string Content { get; set; }

        public List<GaleryImage> GaleryImages { get; set; }
    }
}
