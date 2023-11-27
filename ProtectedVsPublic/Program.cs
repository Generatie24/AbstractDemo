using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPublicVsProtected
{
    public abstract class AbstractBase
    {
        public int PublicValue { get; set; }

        protected int ProtectedValue { get; set; }

        public void PublicMethod()
        {
            Console.WriteLine("PublicMethod called. PublicValue is " + PublicValue);
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("ProtectedMethod called. ProtectedValue is " + ProtectedValue);
        }
    }

    public class DerivedClass : AbstractBase
    {
        public void TestAccess()
        {
            PublicValue = 10; // Toegankelijk
            ProtectedValue = 20; // Toegankelijk

            PublicMethod(); // Toegankelijk
            ProtectedMethod(); // Toegankelijk
        }
    }
    public class UnrelatedClass
    {
        public void TestAccess(AbstractBase abstractBase)
        {
            abstractBase.PublicValue = 30; // Toegankelijk
                                           // abstractBase.ProtectedValue = 40; // Niet toegankelijk, compileerfout

            abstractBase.PublicMethod(); // Toegankelijk
                                         // abstractBase.ProtectedMethod(); // Niet toegankelijk, compileerfout
            abstractBase.PublicValue = 50;
        }
        internal class Program
        {
            static void Main(string[] args)
            {

            }
        }
    }
}