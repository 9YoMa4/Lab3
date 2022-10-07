using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.two
{
    public class B
    {
        public int Aint { get; set; }
        public int Bint { get; set; }

        public B (int a, int b)
        {
            Aint = a; 
            Bint = b; 
        }
        public void Print()
        {
            Console.WriteLine("Hello");
        }

        public virtual void Sum()
        {
            Console.WriteLine(Aint + Aint);
        }
    }
}
