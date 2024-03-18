using System;

namespace Conditional
{
    class Program{
        static void Main(string[] args){
            int theVal =  90;
            //if else

            if(theVal==50){
                Console.WriteLine("theVal is 50");
            }
            else if(theVal<50){
                Console.WriteLine("theVal is less than 50");
            }
            else if(theVal>50 && theVal<100){
                Console.WriteLine("theVal is between 50 and 100");
            }
            else{
                Console.WriteLine("theVal is something else");
            }

            // ternary operation

            Console.WriteLine("Ternary Operator");

            Console.WriteLine(theVal<50 ? "theVal is small" : "theVal is Large");
        }
    }
}