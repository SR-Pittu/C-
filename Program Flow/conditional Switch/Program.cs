using System;
namespace ConditionalOps
{
    class Program{
        static void Main(string[] args){
            int val = 50;

            //switch

            switch(val){
                case 50:
                    Console.WriteLine("val is 50");
                    break;

                 case 60:
                    Console.WriteLine("val is 60");
                    break;

                 case 70:
                 case 80:
                    Console.WriteLine("val is either 70 or 80");
                    break;

                 case 90:
                    Console.WriteLine("val is 90");
                    break;
                default:
                    Console.WriteLine("The val is something other than 50,60,70,80,90");
                    break;
            }

        }
    }
    
}