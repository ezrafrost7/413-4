using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _413_4.Models
{
    public class Restaurant
    {
        [Required]
        public int Rank { get; set; }
        [Required]
        public string Name { get; set; }
        public string FavDish { get; set; } = "It's all tasty!";
        [Required]
        public string Address { get; set; }
        [Phone]
        public string PhoneNum { get; set; }
        public string WebLink { get; set; } = "Coming Soon.";

    }
}
