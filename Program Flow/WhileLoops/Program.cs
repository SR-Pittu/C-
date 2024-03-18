using System;

namespace WhileLoops
{
    class Program{
        static void Main(string[] args){
            string s = "exit";
            //basic while loop
            Console.WriteLine("Basic While Loop");
            while(s!="exit"){
                s = Console.ReadLine();
                Console.WriteLine("You entered: {0}",s);
            }
            Console.WriteLine();

            Console.WriteLine("do While");
            do{
                s = Console.ReadLine();
                Console.WriteLine("You entered: {0}",s); 
            }while(s!="exit");

            Console.WriteLine();
        }
    }
}