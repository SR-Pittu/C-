// See https://aka.ms/new-console-template for more information
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("What is your name?");
        var s = Console.ReadLine();
        Console.WriteLine("Why, hello there " + s);
    }
}