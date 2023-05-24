using System;

namespace Library
{
    public class TwitterChannel : IMessageChannel
    {
        public void Send(Message message, Contact contact)
        {
            Console.WriteLine($"Sending message to {contact.Name}: {message} via Twitter...");
        }
    }
}