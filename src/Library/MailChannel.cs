using System;

namespace Library
{
    public class MailChannel : IMessageChannel
    {
        public void Send(Message message, Contact contact)
        {
            Console.WriteLine($"Sending message to {message.To} via e-mail...");
        }
    }
}