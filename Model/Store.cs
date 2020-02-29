using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gratisAPI.Model
{
    public class Store
    {
        public int Id { get; set; }
        public long PhoneNumber { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int PostCode { get; set; }
        public string streetURL { get; set; }
    }
}
