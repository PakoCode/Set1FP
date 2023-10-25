using System;
using System.Collections.Specialized;

namespace Program;

class Solution
{
    static void Main(string[] args)
    {
        int y1, y2, k = 0;
        y1 = Convert.ToInt32(Console.ReadLine());
        y2 = Convert.ToInt32(Console.ReadLine());
        for(int i = y1; i <= y2; i++){
            if((i % 4 == 0 && i % 100 !=0) || i % 400 == 0)
            {
                k++;
            }
        }
        Console.WriteLine(k);
    }
}