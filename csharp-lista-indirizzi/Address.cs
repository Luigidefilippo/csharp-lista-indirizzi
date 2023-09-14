using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Address
    {
        private string zip;

        public string Name { get;  private set; }
        public string Surname { get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public string Province { get; private set; }
        public int Zip {  get; private set; }

        public Address(string name, string surname, string street, string city, string province, int zip) 
        {
            this.Name = name;
            this.Surname = surname; 
            this.Street = street;
            this.City = city;
            this.Province = province;
            this.Zip = zip;

        }

        public Address(string name, string surname, string street, string city, string province, string zip)
        {
            Name = name;
            Surname = surname;
            Street = street;
            City = city;
            Province = province;
            this.zip = zip;
        }
    }

}
