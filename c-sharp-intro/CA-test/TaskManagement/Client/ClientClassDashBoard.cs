using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database.Models;

namespace TaskManagement.Client
{
    public class ClientClassDashBoard
    {
        public void UpdateSettings(string firstName, string lastName, string password)
        {
            // Update user's first name, last name, and password in the database
            Console.WriteLine($"User full name : {firstName + lastName} &  Password code : {password} ");
        }

        public void CloseAccount(string password)
        {
            // Check if password is correct
            // If correct, delete user's account from the database and log them out
            // If incorrect, cancel operation

        }

        public void ShowReceivedMessages()
        {
            // Retrieve and display all messages sent to the current user
            // Format: <Sequence Number>. <Sender Name> | <Message Text>
        }

        public void ShowSentMessages()
        {
            // Retrieve and display all messages sent by the current user
            // Format: <Sequence Number>. <Recipient Name> | <Message Text>
        }
    }

}




