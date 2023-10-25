using System;

namespace Program;

class Solution
{
    static void Main(string[] args)
    {
        int[] array = new int[3];
        for(int i = 0; i < 3; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int i = 0; i < 2 ; i++) {
            for(int j  = i + 1; j < 3 ; j++) {
                if (array[i] >=  array[j])
                {
                    int aux = array[i];
                    array[i] = array[j];
                    array[j] = aux;
                }
            }
        }
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}