using System;
namespace Exception
{
    class Program{
        static void Main(string[] args){
            int x = 10000;
            int y =0;
            int result;

            //try catch
            try{
                if(x>1000){
                    throw new ArgumentOutOfRangeException("X","X has to be 1000 or less");
                }
            result=x/y;
            Console.WriteLine("The result is : {0}",result);   
            }
            catch(DivideByZeroException e){
                Console.WriteLine("Whoops!...");
                Console.WriteLine(e.Message);
            }
            catch(ArgumentOutOfRangeException e){
                Console.WriteLine("Sorry,  1000 is the limit");
                Console.WriteLine(e.Message);
            }
            finally{
                Console.WriteLine("Completed the Execution in the finally block");
            }
        }
    }
}