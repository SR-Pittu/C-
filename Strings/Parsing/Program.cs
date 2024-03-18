using System;
using System.Globalization;

namespace Parsing{
    class Program{
        static void Main(string[] args){
            string numS1 = "1";
            string numS2 = "2.00";
            string numS3 = "3,000";
            string numS4 = "3,000.00";

            /* Parse function attempts to parse a string into a number 
            but it might throw an exception, so we need o catch that*/

            int targetNum = 0;
            try{
                // Use parse to try a simple integer

                targetNum = int.Parse(numS1);
                Console.WriteLine(targetNum);

                // Use Parse to try a floating point number
                // This only works if the decimal value is 0

                targetNum = int.Parse(numS2,NumberStyles.Float);
                Console.WriteLine(targetNum);

                //Use parse to try a number with thousannds marker

                targetNum = int.Parse(numS3,NumberStyles.AllowThousands);
                Console.WriteLine(targetNum);

                //Use parse to try a number with thousannds marker and decimal

                targetNum = int.Parse(numS4,NumberStyles.Float | NumberStyles.AllowThousands);
                Console.WriteLine(targetNum);

                //this works with other types too like bool

                Console.WriteLine($"{bool.Parse("True")}");

                //or floating point numbers

                Console.WriteLine($"{float.Parse("1.235"):F2}");
            }
            catch{
                Console.WriteLine("Conversion failed");
            }

            // tryParse function is similar but handles the exception for us

            bool succeeded = false;
            succeeded = Int32.TryParse(numS1, out targetNum);
            if(succeeded){
                Console.WriteLine($"{targetNum}");
            }

        }
    }
}