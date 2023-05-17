using System;

namespace Library
{
    public class TwitterChannel : IMessageChannel
    {
        public void Send(Message message, Contact contact)
        {
            Console.WriteLine($"Sending message to {message.To} via Twitter...");
        }
    }
}