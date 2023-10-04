using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        while (true)
        {
            Console.WriteLine("Here are all of the commands:");
            Console.WriteLine("add (Add Contact)");
            Console.WriteLine("search (Search Contact)");
            Console.WriteLine("delete (Delete Contact)");
            Console.WriteLine("print (Print all Contacts)");
            Console.WriteLine("stop (Exit the program)");
            Console.WriteLine("Enter your command:");
            string command = Console.ReadLine();
            switch (command)
            {
                case "add":
                    Console.WriteLine("Enter the name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter phone number: ");
                    string phoneNumber = Console.ReadLine();
                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, phoneNumber);
                        Console.WriteLine("Contact added!");
                    }
                    else
                    {
                        Console.WriteLine("There is already a contact with the same name.");
                    }
                    break;

                case "search":
                    Console.WriteLine("Enter the name you want to search:");
                    string searchName = Console.ReadLine();
                    if (phonebook.ContainsKey(searchName))
                    {
                        Console.WriteLine($"There is the contact: {searchName} -> {phonebook[searchName]}");
                    }
                    else
                    {
                        Console.WriteLine("Contact does not exist.");
                    }
                    break;

                case "delete":
                    Console.WriteLine("Enter the name to delete:");
                    string deleteName = Console.ReadLine();

                    if (phonebook.ContainsKey(deleteName))
                    {
                        phonebook.Remove(deleteName);
                        Console.WriteLine("Contact is deleted");
                    }
                    else
                    {
                        Console.WriteLine("Contact is not found!");
                    }
                    break;

                case "print":
                    Console.WriteLine("Here are all of the contacts in your phonebook:");
                    foreach (KeyValuePair<string,string> item in phonebook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                    break;

                case "stop":
                    return;

                default:
                    Console.WriteLine("Invalid command. Try again:");
                    break;
            }
        }
    }
}
