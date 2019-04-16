using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Cwork1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> names = new List<string>() { "Vasya" };
            List<string> surnames = new List<string> { "Vasilev" };
            List<string> phones = new List<string>() { "0687657687" };
            List<string> adress = new List<string>() { "Dnepr" };
            List<string> emails = new List<string>() { "hdg@gmail.com" };


            string request = "";
            while (request != "0")
            {

                Console.WriteLine("Please enter what do you want to do with your contacts, 0 - to exit program, 1 - to add contact");
                Console.WriteLine("2 - to modify contact, 3 - to remove contact, 4 - to find contact");

                request = Console.ReadLine();
                switch (request)
                {
                    case "0":
                        {
                            break;
                        }
                    case "1":
                        {
                            AddContact(names, surnames, phones, adress, emails);
                            break;
                        }
                    case "2":
                        {
                            ModifyContact(names, surnames, phones, adress, emails);
                            break;
                        }
                    case "3":
                        {
                            RemoveContact(names, surnames, phones, adress, emails);
                            break;
                        }
                    case "4":
                        {
                            FindContact(names, surnames, phones, adress, emails);
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            Console.ReadLine();
        }

        private static void FindContact(List<string> names, List<string> surnames, List<string> phones, List<string> adress, List<string> emails)
        {
            string request = "";
            while (request != "0")
            {

                Console.WriteLine("Please enter what parameter to search for your contacts, 0 - to exit program, 1 - names");
                Console.WriteLine("2 - surnames, 3 - phones, 4 - adress, 5 - emails");

                request = Console.ReadLine();
                switch (request)
                {
                    case "0":
                        {
                            break;
                        }
                    case "1":
                        {
                            Console.WriteLine("Please enter a name of contact you want to find");
                            string str = Console.ReadLine();
                            int i = names.IndexOf(str);

                            if (names.IndexOf(str) >= 0)
                            {
                                Console.WriteLine("Ok, we have found a contact you wanted");
                                Console.WriteLine($"{names[i]}, {surnames[i]}, {phones[i]}, {adress[i]}, {emails[i]}\n");
                            }
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Please enter a surnames of contact you want to find");
                            string str = Console.ReadLine();
                            int i = surnames.IndexOf(str);

                            if (surnames.IndexOf(str) >= 0)
                            {
                                Console.WriteLine("Ok, we have found a contact you wanted");
                                Console.WriteLine($"{names[i]}, {surnames[i]}, {phones[i]}, {adress[i]}, {emails[i]}\n");
                            }
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Please enter a phones of contact you want to find");
                            string str = Console.ReadLine();
                            int i = phones.IndexOf(str);

                            if (phones.IndexOf(str) >= 0)
                            {
                                Console.WriteLine("Ok, we have found a contact you wanted");
                                Console.WriteLine($"{names[i]}, {surnames[i]}, {phones[i]}, {adress[i]}, {emails[i]}\n");
                            }
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Please enter a adress of contact you want to find");
                            string str = Console.ReadLine();
                            int i = adress.IndexOf(str);

                            if (adress.IndexOf(str) >= 0)
                            {
                                Console.WriteLine("Ok, we have found a contact you wanted");
                                Console.WriteLine($"{names[i]}, {surnames[i]}, {phones[i]}, {adress[i]}, {emails[i]}\n");
                            }
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("Please enter a emails of contact you want to find");
                            string str = Console.ReadLine();
                            int i = emails.IndexOf(str);

                            if (emails.IndexOf(str) >= 0)
                            {
                                Console.WriteLine("Ok, we have found a contact you wanted");
                                Console.WriteLine($"{names[i]}, {surnames[i]}, {phones[i]}, {adress[i]}, {emails[i]}\n");
                            }
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }  break;
            }
        }
        private static void RemoveContact(List<string> names, List<string> surnames, List<string> phones, List<string> adress, List<string> emails)
        {
            Console.WriteLine("Enter your's contact name you want to remove: ");
            string str = Console.ReadLine();
            int i;

            if (names.IndexOf(str) >= 0)
            {
                i = names.IndexOf(str) - 1;
                if (i < 0)
                {
                    i = 0;
                }
                Console.WriteLine("Ok, we have found a contact you want to change");
                Console.WriteLine($"{names[i]}, {surnames[i]}, {phones[i]}, {adress[i]}, {emails[i]}");
                Console.WriteLine($"List of contacts contains {names.Count} contacts");
                names.Remove(names[i]);
                surnames.Remove(surnames[i]);
                phones.Remove(phones[i]);
                adress.Remove(adress[i]);
                emails.Remove(emails[i]);
                Console.WriteLine($"List of contacts contains {names.Count} contacts");
            }
            else
            {
                Console.WriteLine("No such contact name found");
            }
        }

        private static void ModifyContact(List<string> names, List<string> surnames, List<string> phones, List<string> adress, List<string> emails)
        {
            try
            {
                Console.WriteLine("Please enter a name of contact you want to change");
                string str = Console.ReadLine();
                int i = names.IndexOf(str);

                if (names.IndexOf(str) >= 0)
                {
                    Console.WriteLine("Ok, we have found a contact you want to change");
                    Console.WriteLine($"{names[i]}, {surnames[i]}, {phones[i]}, {adress[i]}, {emails[i]}");
                    Console.WriteLine("Please enter what do you want to change: 1 - surname, 2 - phone, 3 - adress, 4 - emails, 5- names ");
                    string modifyReq = Console.ReadLine();

                    switch (modifyReq)
                    {
                        case "1":
                            {
                                Console.WriteLine("Please enter a new value for surname");
                                surnames[i] = Console.ReadLine();
                                break;
                            }
                        case "2":
                            {
                                Console.WriteLine("Please enter a new value for phone");
                                phones[i] = Console.ReadLine();
                                break;
                            }
                        case "3":
                            {
                                Console.WriteLine("Please enter a new value for adress");
                                adress[i] = Console.ReadLine();
                                break;
                            }
                        case "4":
                            {
                                Console.WriteLine("Please enter a new value for emails");
                                emails[i] = Console.ReadLine();
                                break;
                            }
                        case "5":
                            {
                                Console.WriteLine("Please enter a new value for names");
                                names[i] = Console.ReadLine();
                                break;
                            }

                        default:
                            break;
                    }
                    Console.WriteLine($"Resulting contact data:{names[i]}, {surnames[i]}, {phones[i]}, {adress[i]}, {emails[i]} \n");
                }
                else
                    Console.WriteLine("No such contact name found");
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private static void AddContact(List<string> names, List<string> surnames, List<string> phones, List<string> adress, List<string> emails)
        {
            int i = 0;
            try
            {
                Console.WriteLine("Enter your's contact names: ");
                names.Add(Console.ReadLine());
                i = names.Count - 1;
                Console.WriteLine("Enter your's contact surnames: ");
                surnames.Add(Console.ReadLine());
                Console.WriteLine("Enter your's contact phone: ");
                phones.Add(Console.ReadLine());
                Console.WriteLine("Enter your's contact adress: ");
                adress.Add(Console.ReadLine());
                Console.WriteLine("Enter your's contact email: ");
                emails.Add(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("New contact has been added: ");
            Console.WriteLine($"{names[i]}, {surnames[i]}, {phones[i]}, {adress[i]}, {emails[i]}");
        }
    }
}
