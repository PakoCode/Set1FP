using System;

namespace Program;

class Solution
{
    static void Main(string[] args)
    {
        int n, d = 2;
        n = Convert.ToInt32(Console.ReadLine());
        if(n < 2) { Console.WriteLine("Numarul nu este prim"); return; }
        for(d = 2; d * d <= n; d++)
        {
            if(n % d == 0) { Console.WriteLine("Numarul nu este prim"); return; }
        }
        Console.WriteLine("Numarul este prim");
    }
}