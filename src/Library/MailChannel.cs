using System;

namespace Library
{
    public class MailChannel : IMessageChannel
    {
        public void Send(Message message, Contact contact)
        {
            Console.WriteLine($"Sending message to {contact.Email}:{message} via e-mail...");
        }
    }
}