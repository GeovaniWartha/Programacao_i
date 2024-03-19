using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240318_01.models
{
    public class Address
    {
        public int AddressId {get; set;}
        public string Street { get; set; }
        public string District { get; set; }
        public int Number { get; set; }
        public string City { get; set; }
        public string FederalState { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public AddressType AdressType { get; set; }
    }

    // enum é uma espécie de objeto simplificado
    public enum AddressType
    {
        Commercial,
        Residential
    }
}