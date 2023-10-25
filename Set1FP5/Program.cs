using System;

namespace Program;

class Solution
{
    static void Main(string[] args)
    {
        int n, k;
        Console.WriteLine("Introduceti numarul: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduceti pozitia de pe care doriti cifra: ");
        k = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        while(n != 0)
        {
            if (i == k) Console.WriteLine(n % 10);
            i++;
            n = n / 10;
        }
    }
}
