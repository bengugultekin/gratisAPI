using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace gratisAPI.Model
{
    public class Basket
    {

        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int ProductCount { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public bool isPurchased { get; set; }

    }
}
