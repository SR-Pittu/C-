using System;
using System.Text;

namespace Builder{
    class Program{
        static void Main(string[] args){
            int jumpCount = 10;
            string[] animals = {"goats", "cats", "pigs"};

            // create a string builder
            StringBuilder sb = new StringBuilder("Intial string.",200);

            // basic stats about the string builder

            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");
            
            // add some strings to thw builder using append

            sb.Append("The quick brown fox ");
            sb.Append("jumped over the lazy dog.");

            //Append line can append a line ending

            sb.AppendLine();

            //Append format can be used to append  formatted strings

            sb.AppendFormat("He did this {0} time.",jumpCount);
            sb.AppendLine();

            //AppendJoin can iterate over a set of values

            sb.Append("He also jumped over ");
            sb.AppendJoin(',',animals);

            //Modify the content using replace

            sb.Replace("fox","frog");

            //Insert content at any index

            sb.Insert(0,"This is the ");

            //Convert to a single string

            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");
            Console.WriteLine(sb.ToString());


        }
    }
}