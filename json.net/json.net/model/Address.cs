using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json.net.model
{
    public class Address
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public City City { get; set; }
    }
}
