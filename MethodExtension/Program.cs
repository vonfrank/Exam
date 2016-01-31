using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person{ name = "Henrik Frank", age = 23 };
            p.SayHello();
        }
    }
}
