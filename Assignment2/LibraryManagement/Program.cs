using System;
using System.Collections.Generic;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Library Management System!");

            Library library = new Library
            {
                Name = "Balaju Library",
                Location = "Balaju, Kathmandu",
                Books = new List<Book>
                {
                    new Book { Title = "Muna Madan", Author = "Mr Tika Dhakal", ISBN = "123456789", IsAvailable = true },
                    new Book { Title = "Parijaat", Author = "Mrs Mina Dhakal", ISBN = "987654321", IsAvailable = false },
                    new Book { Title = "Bato muni ko ful", Author = "Mr Subodh Dhakal", ISBN = "456789123", IsAvailable = true }
                }
            };

            Console.WriteLine(library);

            Console.ReadLine();
        }
    }
}

