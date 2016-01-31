using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideAndOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            Console.WriteLine("{0} calculates: " + bc.AddNumber(1, 1), bc.GetClassName());

            ChildClass cc = new ChildClass();
            Console.WriteLine("{0} calculates: " + cc.AddNumber(1, 1), cc.GetClassName());
            Console.WriteLine();

            List<BaseClass> list = new List<BaseClass>();
            list.Add(bc);
            list.Add(cc);

            foreach(BaseClass b in list)
            {
                Console.WriteLine("{0} calculates: " + b.AddNumber(1, 1), b.GetClassName());
            }

            Console.WriteLine();
            Console.WriteLine("Overloaded method! {0} calculates: " + cc.AddNumber(1, 1, 100), cc.GetClassName());

            bc = bc + 10;
            Console.WriteLine();
            Console.WriteLine("Operator overload! ChildClass + 10 = " + bc.result);

            Console.Read();
        }
    }
}
