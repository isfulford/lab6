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

            //create book
            Book myBook = new Book("12243", "My Book, Your Book", myAuthor);
            Console.WriteLine(myBook.ToString());

            //access the author
            Console.WriteLine(myBook.GetAuthor().ToString());

            //anonymous object
            Book yourBook = new Book("4321", "The Phantom Book", new Author("Jamie", 'f', "jamie@mail.com"));

            //set jamie's email correctly
            yourBook.Author.SetEmail("jamie@crimson.ua.edu");
        }
    }
}
