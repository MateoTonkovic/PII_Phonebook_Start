using Library;
using TwitterUCU;
using WhatsAppApiUCU;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var whatsApp = new WhatsAppApi();
            whatsApp.Send("+59898111020", "Hey! I'm using WhatsApp");

            var twitter = new TwitterMessage();
            twitter.Tweet("Hola!");

            // Crear el contacto dueño
            Contact owner = new Contact("Yo", "099999999", "juanchisosa@gmail.com");

            // // Crear la lista de contactos
            Phonebook phonebook = new Phonebook(owner);

            // // Agregar contactos a la lista
            phonebook.Add(new Contact("Mamá", "099999999", "mama@gmail.com"));
            phonebook.Add(new Contact("Papá", "099999999", "papa@gmail.com"));

            // Enviar un correo a algunos contactos


            // Enviar un WhatsApp a algunos contactos


            // Enviar un SMS a algunos contactos
        }
    }
}
