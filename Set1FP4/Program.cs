using System;

namespace Problema;

class Solution
{
    static void Main(string[] args)
    {
        int y;
        Console.WriteLine("Introduceti anul: ");
        y = Convert.ToInt32(Console.ReadLine());
        if (((y % 4 == 0) && y % 100 != 0) || (y % 400 == 0))
        {
            Console.WriteLine("Anul este bisect");
        }
        else { Console.WriteLine("Anul nu este bisect"); }
    }
}