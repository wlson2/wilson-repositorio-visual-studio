using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json.net.model
{
    public class Contact
    {
        public string Name {  get; set; }
        public Address Address { get; set; }
        public List<Phone> Phones {  get; set; }
        public DateTime DateOfBirth { get; set; }
}
}
