using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.two
{
    public class A
    {
        public B Bobject { get; set; }
        public B Bobject1 { get; set; }
        public B Bobject2 { get; set; }
        public A(B obj, B obj1, B obj2)
        {
            Bobject = obj;
            Bobject1 = obj1;
            Bobject2 = obj2;
        }
    }
}
