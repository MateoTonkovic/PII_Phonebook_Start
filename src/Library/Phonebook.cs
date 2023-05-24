using System.Collections.Generic;
using System;

// |Conocer el dueño|Contact|
// |Conocer los contactos en la lista|MessageChannel|
// |Agregar contactos a la lista||
// |Quitar contactos de la lista||
// |Buscar contactos dados sus nombres||
// |Enviar un mensaje a contactos dados sus nombres a través de un canal||

namespace Library
{
    public class Phonebook
    {
        private List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }

        public Contact Owner { get; }

        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }

        public void Add(Contact person)
        {
            this.persons.Add(person);
        }

        public void Remove(Contact person)
        {
            this.persons.Remove(person);
        }

        public void Send(string[] names, Message message, IMessageChannel channel)
        {
            List<Contact> contacts = this.Search(names);

            foreach (Contact contact in contacts)
            {
                Console.WriteLine($"Sending message to {contact.Name}...");
                // channel.Send(message, contact);
                channel.SendMessage(message.Text, contact);
            }
        }
    }
}