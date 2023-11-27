using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo.Models
{
    public class DHL : Post
    {
        public DHL(Adres adres):base("DHL", adres)
        {
            
        }
       

        public override void HaalPakketOp(Adres ophaladres)
        {
            Console.WriteLine($"DHL haalt pakket op van {ophaladres}");
        }

        public override void LeverPakketAf(Adres afleveradres)
        {
            Console.WriteLine($"DHL levert pakket af op {afleveradres}");
        }
    }
}
