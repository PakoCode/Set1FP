using System;

namespace Program;

class Solution
{
    static void Main(string[] args)
    {
        int a, b, c;
        Console.WriteLine("Introduceti laturile triunghiului: ");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());
        if (a + b <= c || a + c <= b || c + b <= a) { Console.WriteLine("Nu exista triunghi cu aceste lungimi de laturi"); }
        else { Console.WriteLine("Exista"); }

    }
}