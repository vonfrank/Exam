using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExtension
{
    public static class PersonExtension
    {
        public static void SayHello(this Person person)
        {
            Console.WriteLine("{0} says hello :-)", person.name);
            Console.Read();
        }
    }
}
