using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Entro.Models
{
    public class GaleryImage
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        [NotMapped]
        public IFormFile NameFile { get; set; }
        [ForeignKey("Galery")]
        public int GaleryId { get; set; }
        public Galery Galery { get; set; }
    }
}
