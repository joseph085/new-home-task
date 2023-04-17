using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Admin.Commands;
using TaskManagement.Database;

namespace TaskManagement.Admin
{
    public class AdminDashboard
    {
        public static void Introduction()
        {
            Console.WriteLine("Hello dear admin");

            while (true)
            {
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "/promote_to_admin":
                        Promote_to_Admin.Handle();
                        break;
                    
                    case "/depromote_from_admin":
                        Depromote_from_Admin.Handle();
                        break;
                    
                    case "/update_settings":
                        Update_Settings.Handle();
                        break;
                    
                    case "/remove_user":
                        Remove_User.Handle();
                        break;
                    
                    case "/ban_user ":
                        Ban_User.Handle();
                        break;
                    
                    case "/message_to":
                        Message_To.Handle();
                        break;

                    case "/show-users":
                        ShowUsersCommand.Handle();
                        break;
                    
                    case "/show-user-by-email":
                        ShowUserByEmailCommand.Handle();
                        break;
                    
                    case "/show-user-by-id":
                        ShowUserByIdCommand.Handle();
                        break;
                    
                    case "/add-user":
                        AddUserCommand.Handle();
                        break;
                    
                    case "/logout":
                        Console.WriteLine("Bye-bye");
                        return;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
                        break;
                }
            }
        }

    }
}
