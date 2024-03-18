using System;

//Functions can provide default values for their parameters

void PrintWithPrefix(string str,string prefix=""){
    Console.WriteLine($"{prefix} {str}");
}

//Test the default parameters

PrintWithPrefix("Hello There!");
PrintWithPrefix("Hello There!",">:");

//Call with named parameters

PrintWithPrefix(prefix: "%",str:"Hello There!");