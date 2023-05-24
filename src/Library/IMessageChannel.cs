namespace Library
{
    public interface IMessageChannel
    {
        void SendMessage(string message, Contact contact);
    }
}