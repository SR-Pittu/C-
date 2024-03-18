using System;
namespace VarsAndData
{
    class Program{
 static void Main(string[] args){
    //basic data types
    int i= 10;
    float f = 2.0f;
    decimal d = 10.0m;
    bool b = true;
    char c= 'C';

    //string - collection of characters
    string s = "a string";

    // an implicit variable
    var x = 10;
    var z = "Hello!";

    // declare an array
    int[] av = new int[5];
    string[] str = {"one","two","three","four","five","six"};

    //print the values using formatting string

    Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}",i,b,c,s,f,d,x,z);

    //null means no value
    object obj =  null;
    // Console.WriteLine(obj);

    //Implicit conversion
    long bignum;
    bignum =i;
    Console.WriteLine("{0}",bignum);

    //explicit conversion
    float i_to_f=(float)i;
    Console.WriteLine("{0}",i_to_f);

    int f_to_i = (int)f;
    Console.WriteLine("{0}",f_to_i);
 }
 }   
}
