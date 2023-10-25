using System;

namespace Program;

class Solution
{
    static void Main(string[] args)
    {
        int n;
        n =Convert.ToInt32(Console.ReadLine());
        while(n != 0)
        {
            Console.Write(n % 10);
            Console.Write(" ");
            n = n / 10;
        }

    }
}