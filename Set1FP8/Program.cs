using System;

namespace Program;

class Solution
{
    static void Main(string[] args)
    {
        int a, b;
        a = Convert.ToInt32(Console.ReadLine());
        b= Convert.ToInt32(Console.ReadLine());
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine($"Inversate sunt: {a}, {b} ");

    }
}