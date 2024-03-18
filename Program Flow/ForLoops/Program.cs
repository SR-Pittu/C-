using System;

namespace ForLoops
{
    class Program{
        static void Main( string[] args){
            int val = 15;
            int[] nums = new int[] {3,14,15,92,6};
            string str = "The quick brown fox jumps over the lazy dog";
            //basic for loop
            Console.WriteLine("The basic for loop");
            for(int i=0;i<val;i++){
                Console.WriteLine("i is currently {0}",i);
            }
            Console.WriteLine();
            Console.WriteLine("For Each Loop");

            foreach(int i in nums){
                Console.WriteLine("i is currently {0}",i);
            }
            // count number of 'o' in the string

            var count =0;
            foreach(char c in str){
                if (c=='o'){
                    count++;
                }
            }

            Console.WriteLine("Count of o is {0}",count);
        }
    }
}