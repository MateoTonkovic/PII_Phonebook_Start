using System;

namespace Library
{
    public class TwitterChannel : IMessageChannel
    {
        public void SendMessage(string message, Contact contact)
        {
            Console.WriteLine($"Sending message to {contact.Name}: {message} via Twitter...");
        }
    }
}