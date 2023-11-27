using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo.Models
{
    public  class PostBE:Post
    {
        public PostBE(Adres adres) : base("PostBE", adres) 
        { 
        
        }

        public override void HaalPakketOp(Adres ophaladres)
        {
            Console.WriteLine($"PostBE haalt pakket op van {ophaladres}");
        }
        public override void LeverPakketAf(Adres afleveradres)
        {
            Console.WriteLine($"PostBE levert pakket af op {afleveradres}");
        }


    }
}
