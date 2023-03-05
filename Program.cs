using System;
using System.Diagnostics;

class Program
{
    static void Main(){
        // Implemente una funcion que cuando se invoque, espere una entrada´ de texto y devuelva la velocidad de escritura del usuario.
        static double writeSpeed(){
            Stopwatch crono = new Stopwatch();
            Console.WriteLine("Escribe un texto: ");

            crono.Start();
            string texto = Console.ReadLine();
            crono.Stop();

            double ms = (double) crono.ElapsedMilliseconds;

            return ms;
        }

        Console.WriteLine($"Te has demorado: {writeSpeed()} ms");

    
    }
}