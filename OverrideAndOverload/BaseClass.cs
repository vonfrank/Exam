using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideAndOverload
{
    class BaseClass
    {
        int int1, int2;
        public int result { get; set; }
        public BaseClass() { }
        public int AddNumber(int int1, int int2)
        {
            this.int1 = int1;
            this.int2 = int2;
            result = int1 + int2;
            return result;
        }

        public virtual string GetClassName()
        {
            return "BaseClass";
        }

        public static BaseClass operator +(BaseClass baseclass, int number)
        {
            baseclass.result = baseclass.result + number;
            return baseclass;
        }
    }
}
