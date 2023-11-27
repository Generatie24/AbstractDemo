using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo.Models
{
    public class Adres
    {
        public string Naam { get; set; }
        public string Stad { get; set; }
        public string  Postcode { get; set; }
        public string Land { get; set; }

        public Adres(string naam, string stad, string postcode, string land)
        {
            Naam = naam;
            Stad = stad;
            Postcode = postcode;
            Land = land;
        }

        override public string ToString()
        {
            return $"{Naam} - {Stad} - {Postcode} - {Land}";
        }   
    }
}
