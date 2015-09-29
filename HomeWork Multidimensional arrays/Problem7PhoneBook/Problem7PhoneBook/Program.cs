using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7PhoneBook
{
    class Program
    {
       public static Dictionary<string, List<string>> contacts = new Dictionary<string, List<string>>();
        static void Main(string[] args)
        {
            while(true)
            {
                string input = Console.ReadLine();

                if (input == "search")
                    break;

                addToContacts(input);

            }

            while(true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                    break;

                printContact(input);
            }

            Console.ReadLine();
        }

        static void addToContacts(string input)
        {
            int index = input.IndexOf('-');

            string contactName = input.Remove(index);
            string contactNumber = input.Remove(0, index + 1);

            if(contacts.ContainsKey(contactName))
            {
                contacts[contactName].Add(contactNumber);
            }
            else
            {
                List<string> number = new List<string>();

                number.Add(contactNumber);
                contacts.Add(contactName, number);
            }
        }

        static void printContact(string name)
        {
            if(contacts.ContainsKey(name))
            {
                Console.WriteLine("{0} -> {1}", name, string.Join(", ", contacts[name]));
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", name);
            }
            
        }
    }
}
