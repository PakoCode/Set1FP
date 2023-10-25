using System;

namespace Program;

class Solution
{
    static void Main(string[] args)
    {
        int n, k = 0;
        int[] frequency = new int[10];
        n = Convert.ToInt32(Console.ReadLine());
        while(n != 0) {
            frequency[n%10]++;
            n = n / 10;
        }
        for(int i  = 0; i < frequency.Length; i++)
        {
            if (frequency[i] > 0) k++;
        }
        if (k > 2) Console.WriteLine("Nu!");
        else Console.WriteLine("Da!");
    }

}