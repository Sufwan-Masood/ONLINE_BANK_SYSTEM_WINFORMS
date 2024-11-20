using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SE_bank
{
    public class Person
    {
        // Properties common to both User and Admin
        public int ID { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Email { get; protected set; }
        public string Contact { get; protected set; }
        public string IBAN { get; protected set; }
        public string Password { get; protected set; } // Password for authentication

        // Constructor to initialize common properties
        public Person(int id, string firstName, string lastName, string email, string contact, string iban, string password)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Contact = contact;
            IBAN = iban;
            Password = password;
        }

        // Method to display person information
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Contact: {Contact}");
            Console.WriteLine($"IBAN: {IBAN}");
        }
    }
}

