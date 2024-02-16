using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv in ett tal du vill undersöka");
        int x = int.Parse(Console.ReadLine());
        Primtal(x);
        
        
    }
    static int Primtal(int x)
    {
        for (int i = 2; i < x; i++)
        {
            if (x % i == 0)
            {
                Console.WriteLine("Talet är inte ett primtal");
                return x;
            }
            else
            {
                Console.WriteLine("Talet är ett primtal");
                return x;
            }
        }
        return x;
        
    }
}