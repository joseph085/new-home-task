using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class Depromote_from_Admin
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
                        user.IsAdmin = false;
                        Console.WriteLine($" Already is now uadmin ");
                        return;
                    }


                }


            }
            Console.WriteLine("Email is not found");
            //Console.Write("Enter the admin email: ");
            //string email = Console.ReadLine();

            //// Check if email exists in the admin list and remove if found
            //if (admin.ContainsKey(email))
            //{
            //    if (userList.ContainsKey(email))
            //    {
            //        Console.WriteLine($"User with email {email} is already a regular user.");
            //    }
            //    else
            //    {
            //        userList.Add(email, adminList[email]);
            //        adminList.Remove(email);
            //        Console.WriteLine($"Admin with email {email} has been demoted to a regular user.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"Admin with email {email} was not found.");
            //}















        }





    }
}
