using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int experience { get; set; }

        public Employee() { }

        public void PromoteEmployee(List<Employee> listOfEmployees, IsPromotable promotable)
        {
            foreach(Employee e in listOfEmployees)
            {
                if (promotable(e))
                {
                    Console.WriteLine("ID: {0} with name: {1} is promotable", e.id, e.name);
                }
            }
            Console.Read();
        }
    }
}
