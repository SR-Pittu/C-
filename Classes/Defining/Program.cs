using System;

namespace Defining{
    class Program{
        static void Main(string[] args){
            // create new object instances using the "new" operator

            Book b1 = new Book("War and Peace","Leo Tolstoy",825);

            Book b2 = new Book("Twilight","Lea",567);

            // call a method on the object

            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b2.GetDescription());

            // try to set one of the properities -- this will result an error

            b1._author = "Sobha";
        }
    }
}