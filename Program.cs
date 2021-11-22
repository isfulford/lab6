using System;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //create author
            Author myAuthor = new Author("Jeff Lucas", 'm', "jslucas@cba.edu");
            Console.WriteLine(myAuthor.ToString());
            Console.WriteLine();


            //create book
            Book myBook = new Book("12243", "My Book, Your Book", myAuthor);
            Console.WriteLine(myBook.ToString());
            Console.WriteLine();


            //access the author
            Console.WriteLine(myBook.GetAuthor().ToString());
            Console.WriteLine();


            //anonymous object
            Book yourBook = new Book("4321", "The Phantom Book", new Author("Jamie", 'f', "jamie@mail.com"));
            Console.WriteLine(yourBook.ToString());
            //Console.WriteLine();

            //set jamie's email correctly
            yourBook.GetAuthor().SetEmail("jamie@crimson.ua.edu");
            Console.WriteLine(yourBook.ToString());
        }
    }
}
