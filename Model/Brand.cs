using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gratisAPI.Model
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string logoURL { get; set; }

        //0 sa değil, 1 se sadece gratiste
        public bool OnlyInGratis { get; set; }
    }
}
