using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gratisAPI.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public long PhoneNumber { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int PostCode { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
