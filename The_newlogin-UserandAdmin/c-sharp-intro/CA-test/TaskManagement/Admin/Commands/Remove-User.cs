using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class Remove_User
    {
        public static void Handle()
        {
            foreach (User user in DataContext.Users)
            {
                if (user == null) 
                {
                    Console.WriteLine("Invalid Email :");
                }
                else if (user.IsAdmin)
                {
                    Console.WriteLine("You not may Admin");
                }
                else
                {
                    Console.WriteLine($"user {user.Name + user.LastName} has been Deleted! ");
                }
                
            }


        }

    }
}
