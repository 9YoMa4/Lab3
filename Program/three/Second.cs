using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.three
{
    internal class Second: Person
    {
        public Second(string n, string c)
        {
            Name = n;
            Country = c;
        }

        public void Print()
        {
            Console.WriteLine("Second class");
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Country = {Country}");
        }
    }
}
