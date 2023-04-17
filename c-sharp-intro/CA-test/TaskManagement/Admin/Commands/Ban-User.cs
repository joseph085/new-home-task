using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class Ban_User
    {
        public static void Handle()
        {
            foreach (User user in DataContext.Users)
            {
                if (user == null) 
                {
                    Console.WriteLine("Invalid mail");
                }   
                else if (user.IsAdmin)
                {
                    user.IsAdmin = false;
                    Console.WriteLine("Earlier banned profile");
                }
                else if (!user.IsAdmin)
                {
                    Console.WriteLine("You are can`t ban profile");
                }
                else{
                    user.IsAdmin = false;
                    Console.WriteLine($" You has {user.Name + user.Surname} been banned! ");
                }
            }


        }




    }
}
