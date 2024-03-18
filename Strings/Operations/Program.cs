using System;

namespace Operations
{
    class Program{
        static void Main(string[] args){
            string os;
            string s1 = "The quick brown fox jumps over the lazy dog.";
            string s2 = "This is a string";
            string s3 = "THIS is a STRING";
            string[] strs ={"one","two","three","four"};

            //length of string
            Console.WriteLine(s1.Length);

            //access individual characters
            Console.WriteLine(s1[14]);

            //iterate over a string like any other sequence of values
            foreach(char c in s1){
                Console.Write(c);
                if(c=='b'){
                    Console.WriteLine();
                    break;
                }
            }

            //String concatination

            os = String.Concat(strs);
            Console.WriteLine(os);

            //String join
            os = String.Join(".",strs);
            Console.WriteLine(os);
              
            os = String.Join("----",strs);
            Console.WriteLine(os);

            // string comparision

            int res = String.Compare(s2,"This is a string");
            Console.WriteLine(res);

            bool isEquals = s2.Equals(s3);
            Console.WriteLine(isEquals);
            
            //String Searching

            Console.WriteLine(s1.IndexOf('e'));
            Console.WriteLine(s1.IndexOf("fox"));

            Console.WriteLine(s1.LastIndexOf('e'));
            Console.WriteLine(s1.LastIndexOf("the"));

            os = s1.Replace("fox","cat");
            Console.WriteLine(os);
            Console.WriteLine(os.IndexOf("fox"));
        }
    }
}