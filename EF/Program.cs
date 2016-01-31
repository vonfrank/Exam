using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DataModel())
            {
                var users = from u in db.UsersVF select u;

                foreach (UsersVF user in users)
                {
                    Console.WriteLine(user.userFirstname + " has username: " + user.userName);
                }

                Console.ReadLine();
            }
        }
    }
}
