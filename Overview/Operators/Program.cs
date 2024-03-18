using System;

namespace Operators{
    class Program{
        static void Main(string[] args){
            int x=10,y=5;
            string a = "abcd", b = "efgh";

            //basic math operations
            Console.WriteLine("----------Basic Math----------");
            Console.WriteLine(a+b);
            Console.WriteLine((x/y)*x);

            // Increment and decrement
            Console.WriteLine("----------Shorthand----------");
            x++;
            y--;
            Console.WriteLine(x);
            Console.WriteLine(y);

            a+=b;
            Console.WriteLine(a);

            //Logical operators
            Console.WriteLine(x>y && y>=5);
            Console.WriteLine(x>y || y>=5);

            //null-coalescing operator

            string s = "hello";
            Console.WriteLine(s ?? "Unknow string");

            s ??= "Sobha";

            Console.WriteLine(s);
        }
    }
}