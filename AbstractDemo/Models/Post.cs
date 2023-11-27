using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo.Models
{
    public abstract class Post
    {
        public string Naam;
        protected Adres BedrijfsAdres { get; set; }

        public Post(string naam, Adres adres)
        {
            Naam = naam;
            BedrijfsAdres = adres;
        }

        public decimal BerekenVerzendKosten(PakketGrootte grootte,decimal prijs)
        {
            switch (grootte)
            {
                case PakketGrootte.Klein:
                    return prijs;
                case PakketGrootte.Middel:
                    return prijs;
                case PakketGrootte.Groot:
                    return prijs;
                default:
                    Console.WriteLine("Ongeldige pakkettgrotte opgegeven");
                    return 0;
            }
        }
        public abstract void HaalPakketOp(Adres ophaladres);
        public abstract void LeverPakketAf(Adres afleveradres);


    }
}
