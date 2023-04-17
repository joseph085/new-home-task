using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class Update_Settings
    {

        public static void Handle()
        {
            Console.WriteLine("You are Welcome to User  :");
            foreach (User users in DataContext.Users)
            {
                string newAddName = Console.ReadLine();
                string newAddSurname = Console.ReadLine();
                string newAddOPassword = Console.ReadLine();

                users.Name = newAddName;
                users.Surname = newAddSurname;
                users.Password = newAddOPassword;
                Console.WriteLine("Auspiciously updating");
            }
        }

       
    }
}
