using System;

namespace Probleme;

class rezolvare
{
    static void Main(string[] args)
    {
        double a, b, c, x1, x2, delta;
        Console.WriteLine("Introduceti prima valoare a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduceti a doua valoare b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduceti a treia valoare c: ");
        c = Convert.ToInt32(Console.ReadLine());
        delta = (b * b) - (4 * a * c);
        if(delta == 0)
        {
            x1 = -b/(2*a);
            Console.WriteLine("Solutia este " + x1);
            return;
        }
        if(delta > 0)
        {
            x1 = (-b + Math.Sqrt(delta)) / (2*a);
            x2 = (-b + Math.Sqrt(delta)) / (2*a);
            Console.WriteLine("Solutiile sunt: " + x1, ',' + x2);
            return;
        }
        if(delta < 0)
        {
            x1 = (-b + Math.Sqrt(-delta)) / (2 * a);
            x2 = (-b + Math.Sqrt(-delta)) / (2 * a);
            Console.WriteLine("Solutiile sunt: " + x1, ',' + x2);
            //treat this case;
            return;
        }
        
    }
}