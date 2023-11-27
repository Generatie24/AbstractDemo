using AbstractDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            string lijn = new string('-', 50);

            Adres ophaaladres1BE = new Adres("Straat A", "Stad A", "1001", "Belgie");
            Adres ophaaladres2BE = new Adres("Straat B", "Stad B", "1001", "Belgie");
            Adres ophaaladres3BE = new Adres("Straat C", "Stad C", "1001", "Belgie");

            PostBE postBE1 = new PostBE(ophaaladres1BE);
            postBE1.HaalPakketOp(ophaaladres1BE);
            decimal verzendkosten = postBE1.BerekenVerzendKosten(PakketGrootte.Groot, 15);
            Console.WriteLine(verzendkosten);
            postBE1.LeverPakketAf(ophaaladres2BE);
           
            
            //DHL dHL = new DHL(ophaaladres3BE);

        }
    }
}
