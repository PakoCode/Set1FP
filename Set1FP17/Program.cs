using System;

namespace Program;

class Solution
{
    static void Main(string[] args)
    {
        int a, b, c, d, cmmdc, cmmmc;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = a;
        d = b;
        while(a != b)
        {
            if (a > b) a = a - b;
            if (a < b) b = b - a;
        }
        cmmdc = a;
        cmmmc = (c * d) / cmmdc;
        Console.WriteLine(cmmdc);
        Console.WriteLine(cmmmc);
    }

}