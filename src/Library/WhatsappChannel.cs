using System;
namespace Library
{
    public class WhatsappChannel : IMessageChannel
    {
        public void SendMessage(string message, Contact contact)
        {
            Console.WriteLine($"Sending message to {contact.Name} : {message} via WhatsApp...");
        }
    }
}
