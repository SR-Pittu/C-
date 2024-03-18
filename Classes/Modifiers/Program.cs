using System;

namespace Modifiers{
    class Program{
        static void Main(string[] args){
            //create a book instance

            Book b1 = new Book("War and Peace","Leo Tolstoy",987);
            Console.WriteLine(b1.GetDescription());

            //In previous example, this would fail
            // but will now wor since the field name is declared as public

            b1._name = "Cat in the hat";
            Console.WriteLine(b1.GetDescription());

            // set data functions instead of accessing fields directly
            b1.SetName("Grapes of Wrath");
            b1.SetAuthor("John Steinbeck");
            b1.SetPageCount(789);

            Console.WriteLine(b1.GetDescription());

        }
    }
}