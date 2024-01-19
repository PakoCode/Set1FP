using System;

class Program 
{
    static void Main()
    {
        Console.Write("Introduceti numaratorul (m): ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Introduceti numitorul (n): ");
        int n = int.Parse(Console.ReadLine());

        string rezultat = ConversieDecimala(m, n);
        Console.WriteLine($"Rezultat: {rezultat}");
    }

    static string ConversieDecimala(int numarator, int numitor)
    {
        int catul = numarator / numitor;
        int restul = numarator % numitor;

        if (restul == 0)
        {
            return catul.ToString();
        }

        string rezultat = catul.ToString() + ".";
        string ParteIntreaga = rezultat;

        Dictionary<int, int> pozitiiRest = new Dictionary<int, int>();

        restul *= 10;
        while (restul != 0)
        {
            if (pozitiiRest.ContainsKey(restul))
            {
                int pozitiePerioada = pozitiiRest[restul];
                string parteNonPerioada = rezultat.Substring(2, pozitiePerioada - 2);
                string partePerioada = rezultat.Substring(pozitiePerioada, rezultat.Length - pozitiePerioada);
                return $"{ParteIntreaga}{parteNonPerioada}({partePerioada})";
            }

            pozitiiRest.Add(restul, rezultat.Length);

            int catulNou = restul / numitor;
            rezultat += catulNou.ToString();
            restul = (restul % numitor) * 10;
        }

        return rezultat;
    }
}