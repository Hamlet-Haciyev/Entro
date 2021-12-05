using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Models.ViewModels
{
    public class HomeRelated
    {
        public Setting setting { get; set; }
        public List<Social>  socials { get; set; }
        public Concert concert { get; set; }
        public About about { get; set; }
        public Slider slider { get; set; }
        public List<Galery> gallery { get; set; }

    }
}
