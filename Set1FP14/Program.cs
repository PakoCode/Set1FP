using System;

namespace Program;

class Solution
{
    static void Main(string[] args)
    {
        int n, nr, invers = 0;
        n = Convert.ToInt32(Console.ReadLine());
        nr = n;
        while(n != 0)
        {
            invers = invers * 10 + n % 10;
            n = n / 10;
        }
        if (invers == nr) Console.WriteLine("Numarul este palindrom");
        else Console.WriteLine("Numarul nu este palindrom");
    }
}