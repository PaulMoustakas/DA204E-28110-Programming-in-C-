using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    /// <summary>
    /// Address class to store Address data for a Participant
    /// </summary>
    internal class Address
    {
        public string City { get; set; }
        public Countries Country { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }


        /// <summary>
        /// Default constructor 
        /// </summary>
        public Address() { } 
     
        public Address (string street, string city, string zipCode, Countries country)
        {
            this.Street = street;
            this.City = city;
            this.ZipCode = zipCode;
            this.Country = country;
        }


       override
       public string ToString()
        {
            string strOut = "";
            strOut += String.Format("{0,-25}", Street);
            strOut += String.Format("{0,-10}", City);
            strOut += String.Format("{0,-10}", ZipCode);
            strOut += String.Format("{0,1}", Country);
            return strOut;
        }
    }
}

