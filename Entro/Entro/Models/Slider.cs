using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Entro.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(40)]
        public string SubTitle { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(2000)]
        public string Description { get; set; }
        [MaxLength(250)]
        public string BgImage { get; set; }
        [NotMapped]
        public IFormFile BgImageFile { get; set; }
    }
}
