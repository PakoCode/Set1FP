using System;

namespace Problema;

class Solution
{
    static void Main(string[] args)
    {
        int n, k;
        Console.WriteLine("Introduceti valoarea lui n: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduceti valorea lui k: ");
        k = Convert.ToInt32(Console.ReadLine());
        if (n % k == 0) Console.WriteLine("k este divizor a lui n");
        else
        {
            Console.WriteLine("k nu esti divizor a lui n");
        }

    }
}
