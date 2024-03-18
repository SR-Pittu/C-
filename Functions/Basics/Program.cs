 using System;

/*functions are used to group re-usable code together in a single unit
that can be customized with parameters*/

// Functions have return type, name, and optional parameters

float MileToKm(float miles){
    float res = miles *1.6f;
    return res;
}

//function with no return value has a'void' type

void PrintWithPrefix(string s){
    Console.WriteLine($"::>{s}");
}

// call first function

Console.WriteLine($"The result is {MileToKm(8.0f)}");
Console.WriteLine($"The result is {MileToKm(52.0f)}");
Console.WriteLine($"The result is {MileToKm(89.0f)}");

// call second function

PrintWithPrefix("Test String");
PrintWithPrefix("Another Test String");
PrintWithPrefix("Last Test String");