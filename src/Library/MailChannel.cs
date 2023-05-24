using System;

namespace Library
{
    public class MailChannel : IMessageChannel
    {
        public void SendMessage(string message, Contact contact)
        {
            Console.WriteLine($"Sending message to {contact.Email}:{message} via e-mail...");
        }
    }
}