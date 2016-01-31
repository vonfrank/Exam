using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empl = new List<Employee>();

            empl.Add(new Employee() { id = 1, name = "Henrik", experience = 5 });
            empl.Add(new Employee() { id = 2, name = "Søren", experience = 1 });
            empl.Add(new Employee() { id = 3, name = "Steffen", experience = 10 });

            Employee e = new Employee();
            e.PromoteEmployee(empl, x => x.experience >= 5);
        }
    }
}
