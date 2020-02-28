using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace gratisAPI.Model
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength =3)]
        public string Title { get; set; }

        public List<Category> SubCategories;
    }
}
