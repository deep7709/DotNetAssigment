using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    class RetailSalesman : Salesman
    {
        public RetailSalesman(string firstName, string lastName) : base(firstName, lastName)
        {

        }
        public override void sell()
        {
            Console.WriteLine("Hello " + fullName + ". Thanks for buy retail");
        }
    }
}
