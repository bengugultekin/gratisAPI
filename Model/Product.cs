using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace gratisAPI.Model
{
    public class Product 
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        public string Description { get; set; }

        public Color color { get; set; }

        public decimal Price { get; set; }

        public string Brand { get; set; }

        public int CategoryId { get; set; }

        public string URL { get; set; }
    }
}
