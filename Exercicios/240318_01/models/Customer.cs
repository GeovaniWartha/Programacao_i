using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace _240318_01.models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public DateTime BirthDate { get; set; }
        public string EmailAddress { get; set; }

        //public Address Address1 { get; set; }
        //public Address Address2 {get; set; }
        public List<Address> Adresses = new List<Address>();

        //metodos
        public bool Validate()
        {
            return true;
        }
    }
}