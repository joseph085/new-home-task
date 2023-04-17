using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class Message_To
    {
        public static void Handle()
        {
            foreach (User sendinguser in DataContext.Users)
            {
                User receiveUser = null;
                string basicallyMessage = string.Empty;
                while (sendinguser == receiveUser)
                {
                    Console.WriteLine("Pls enter the words ");
                    basicallyMessage = Console.ReadLine();
                    break;
                }
                while (sendinguser != null)
                {

                }
            }


        }



    }
}
