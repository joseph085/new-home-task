using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class Promote_to_Admin
    {

        public static void Handle()
        {
            Console.Write("Please enter email:");
            string email = Console.ReadLine();
            foreach (User user in DataContext.Users)
            {
                if (user.Email == email)
                {
                    if (user.IsAdmin)
                    {
                        Console.WriteLine("You are already an admin");
                        return;
                    }
                    else 
                    {
                        user.IsAdmin = true;
                        Console.WriteLine($"{user.Name} is now admin ");
                        return;
                    }


                }


            }
            Console.WriteLine("Email is not found");
        }
    }
}
