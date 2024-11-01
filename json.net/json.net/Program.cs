using json.net.model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace json.net
{
    class Program
    {
        private static string _path = @"C:\Json\Contacts.Json";
        static void Main(string[] args)
        {
            var contacts = GetContacts();
            SerializeJsonFile(contacts);
        }
        #region "Writing JSON"
        public static void SerializeJsonFile(List<Contact> Contacts) 
        {
            string ContactsJson = JsonConvert.SerializeObject(Contacts.ToArray(), Formatting.Indented);
            File.WriteAllText(_path, ContactsJson);
        
        }
        public static List<Contact> GetContacts() 
        {
            List<Contact> Contacts = new List<Contact>
            {
                new Contact
                {
                   Name = "Jhon Wick",
                   DateOfBirth = new DateTime(1908, 05, 17),
                   Address = new Address {
                       Street = "Calle Segunda",

                    Number = "15",
                       City = new City {
                           Name = "Santo Domingo",
                           Country = new Country { Code = "RD", Name = "Republica Dominicana" }
                       }
                   },
                    Phones = new List<Phone>{
                       new Phone {Name = "Personal", Number = "8297515621" },
                       new Phone {Name = "work", Number = "8297693878"}


                   }
                },
                 new Contact
                {
                   Name = "Alfredo",
                   DateOfBirth = new DateTime(1975, 03, 27),
                   Address = new Address {
                       Street = "Av. Mariscal La Mar",

                    Number = "1260",
                       City = new City {
                           Name = "Lima",
                           Country = new Country { Code = "PER", Name = "Peru" }
                       }
                   },
                    Phones = new List<Phone>{
                       new Phone {Name = "Personal", Number = "287282759" },
                       new Phone {Name = "work", Number = "289292580"}


                   }
                }, new Contact
                {
                   Name = "Pablo Coelo",
                   DateOfBirth = new DateTime(1999, 08, 15),
                   Address = new Address {
                       Street = "Av. 9 de julio",

                    Number = "532",
                       City = new City {
                           Name = "Buenos Aires",
                           Country = new Country { Code = "ARG", Name = "Argentina" }
                       }
                   },
                    Phones = new List<Phone>{
                       new Phone {Name = "Personal", Number = "458694586" },
                       new Phone {Name = "work", Number = "725913864"}


                   }
                },


            };  
            
                  
            return Contacts;
        }
        #endregion
    }
}
