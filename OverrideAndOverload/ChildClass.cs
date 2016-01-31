using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideAndOverload
{
    class ChildClass : BaseClass
    {
        int int1, int2, result;
        public ChildClass() { }

        public int AddNumber(int int1, int int2)
        {
            this.int1 = int1;
            this.int2 = int2;
            result = int1 + int2;
            return result - 1;
        }

        public int AddNumber(int int1, int int2, int int3)
        {
            return int1 + int2 + int3;
        }

        public override string GetClassName()
        {
            return "ChildClass";
        }
    }
}
