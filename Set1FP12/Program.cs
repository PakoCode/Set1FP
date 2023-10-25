using System;

namespace Program;

class Solution
{
    static void Main(string[] args)
    {
        int a, b, n;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        n = Convert.ToInt32(Console.ReadLine());
        for(int i = a; i <=b; i++)
        {
            if(n % i == 0)
            {
                Console.Write(i);
                Console.Write(" ");
            }
        }
    }
}