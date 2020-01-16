using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{   
    class Program
    {
        static void Main(string[] args)
        {
            CarSalesman c = new CarSalesman("Nishant", "Ambaliya");
            c.sell();
            RetailSalesman r = new RetailSalesman("Himansu", "Bhanderi");
            r.sell();
            Console.ReadLine();

        }
    }
}
