using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    abstract class Salesman
    {
        private string lastName, firstName;
        public Salesman(string firstName,string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public abstract void sell();
        public string fullName
        {
            get { return firstName + " " + lastName; }
        }
        public string getName()
        {
            return firstName +" "+ lastName;
        }
    }
}
