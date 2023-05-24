using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de WhatsAppApi
            WhatsAppApi whatsappApi = new WhatsAppApi();

            // Crear el contacto dueño
            Contact owner = new Contact("Yo", "099999999", "juanchisosa@gmail.com");

            // Crear la lista de contactos
            Phonebook phonebook = new Phonebook(owner);

            // Agregar contactos a la lista
            phonebook.Add(new Contact("Mamá", "099999999", "mama@gmail.com"));
            phonebook.Add(new Contact("Papá", "099999999", "papa@gmail.com"));

            // Buscar contactos en la lista
            string[] searchNames = {"Mamá", "Papá"};
            var searchResults = phonebook.Search(searchNames);
            Console.WriteLine("Resultados de la búsqueda:");
            foreach (var contact in searchResults)
            {
                Console.WriteLine($"Nombre: {contact.Name}, Teléfono: {contact.Phone}");
            }


            // Enviar un correo a algunos contactos


            // Enviar un WhatsApp a algunos contactos
            Contact recipient = owner;
            Message message = new Message("Remitente", recipient.Phone, "Hola, este es un mensaje de prueba");
            IMessageChannel channel = new WhatsAppApiAdapter(whatsappApi);
            phonebook.Send(recipient, message, channel);


            // Enviar un SMS a algunos contactos
        }
    }
}
