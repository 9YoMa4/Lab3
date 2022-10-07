using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.three
{
    internal class Third: Person
    {
        public Third(string n, string f)
        {
            Name = n;
            FirstName = f;
        }

        public void Print()
        {
            Console.WriteLine("Third class");
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"FirstName = {FirstName}");
        }
    }
}
