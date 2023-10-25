using System;

namespace Program;

class Solution
{
    static void Main(string[] args)
    {
        int a, b, intermediar;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        intermediar = b;
        b = a;
        a = intermediar;
        Console.WriteLine($"Valorile inversate sunt: {a}, {b} ");

    }
}