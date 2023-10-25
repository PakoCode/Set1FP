using System;

namespace Program;

class Solution
{
    static void Main(string[] args)
    {
        int n, i;
        n = Convert.ToInt32(Console.ReadLine());
        for( i = 1; i  <= n; i++)
        {
           if(n % i == 0)
            {
                Console.WriteLine(i);
            }
        }

    }
}
