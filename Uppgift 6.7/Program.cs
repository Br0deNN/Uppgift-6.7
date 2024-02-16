using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv in ett tal du vill undersöka");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine(Primtal(x));
        
        
    }
    static bool Primtal(int x)
    {
        int delx = 0;
        for (int i = 2; i < x; i++)
        {
            if (x % i == 0)
            {
                delx++;
            }
        }
        if (delx == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
