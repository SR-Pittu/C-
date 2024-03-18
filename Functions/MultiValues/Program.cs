using System;

namespace MultiValues{
    class Program{
        static void Main(string[] args){

            // Tuples are grouped values added in c#7
            
            (int a, int b) tuple1 = (5,10);
            var tuple2 = ("Some text", 10.5f);

            // Tuple values are mutable

            tuple1.b =20;
            tuple2.Item1 = "New String";

            Console.WriteLine($"{tuple1.a} {tuple1.b}");
            Console.WriteLine($"{tuple2.Item1} {tuple2.Item2}");            
            
            // functions cam work with tuples

            (int, int) result =  PlusTime(5,10);
            Console.WriteLine($"SUm : {result.Item1} & Product : {result.Item2}");

        }

        // Functions can return multiple values using tuples

        static (int,int) PlusTime(int a,int b){
            return (a+b,a*b);   
        }
    }
}