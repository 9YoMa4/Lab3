using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.one
{
    public class Color
    {
        public virtual void Method(int a, string b)
        {
            Console.WriteLine($"{a}, {b}");
        }
    }
}
