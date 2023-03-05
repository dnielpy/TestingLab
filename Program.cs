using System;
using System.Diagnostics;

class Program
{
    static void Main(){
        // Implemente una funcion que reciba tres n´ umeros enteros y retorne´ true o false en dependencia de si forman o no una fecha.
        
        static bool fechaTester(int x, int y, int z) {
            if (x > 0 && x < 31 && y > 0 && y < 12 && z > 0 && z < 3000)
            {
                return true;
            }
            return false;
        }
        System.Console.WriteLine("Escribe el day: ");
        int day = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Escribe el month: ");
        int month = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Escribe el year: ");
        int year = int.Parse(Console.ReadLine());

        System.Console.WriteLine(fechaTester(day, month, year));
    
    }
}