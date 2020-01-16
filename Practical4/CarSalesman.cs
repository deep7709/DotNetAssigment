using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    class CarSalesman : Salesman 
    {
        public CarSalesman(string firstName,string lastName) : base(firstName, lastName)
        {

        }
        public override void sell()
        {
            Console.WriteLine("Hello " + this.getName() + ". Thanks for buy car");
        }
    }
}
