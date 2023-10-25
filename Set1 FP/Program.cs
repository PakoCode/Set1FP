using System;

namespace Probleme;

class program
{
    static void Main(string[] args)
    {
        int x, a, b;
        Console.WriteLine("Introduceti prima valoare");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduceti a doua valoare");
        b = Convert.ToInt32(Console.ReadLine());
        if(a == 0)
        {
            if(b  == 0)
            {
                Console.WriteLine("0 este egal cu 0");
                return;
            }
            Console.WriteLine("Nu exista solutii!");
            return;
        }
        x = -b / a;
        Console.WriteLine(x);
    }
}
