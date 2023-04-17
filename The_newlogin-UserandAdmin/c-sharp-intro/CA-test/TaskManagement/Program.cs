using TaskManagement.Common;
using TaskManagement.Database;

namespace TaskManagement
{
    //Encapsulaiton

    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("|Avialable command|");
                Console.WriteLine("Register :");
                Console.WriteLine("Exit");
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "|Register|":
                        RegisterCommand.Handle();
                        break;
                    case "|Login|":
                        LoginCommand.Handle();
                        break;
                    case "|Exit|":
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
