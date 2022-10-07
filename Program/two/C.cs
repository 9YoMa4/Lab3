using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.two
{
    public class C: B
    {
        public C(int a, int b):base(a, b)
        {

        }
        public override void Sum()
        {
            Console.WriteLine("class C");

            Console.WriteLine($"A = {Aint}");
            Console.WriteLine($"B = {Bint}");
            base.Sum();
            Console.WriteLine();
        }
    }
}
