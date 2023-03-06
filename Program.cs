using System;
using System.Diagnostics;

class Program
{
    static void Main(){

        static void Write(string texto){
            Console.WriteLine(texto);
        };
        
        static void timeOfFlight(int hora1, int minutos1, int hora2, int minutos2){
            //Hora = hora1 : minutos1
            int hora = hora2 - hora1;               //Mal
            int minutos = minutos2 - minutos1;      //Mal

            System.Console.WriteLine($"{hora}:{minutos}");
        }
        Write("Escribe la hora A: ");
        int hora = int.Parse(Console.ReadLine());
        Write("Escribe los minutos A: ");
        int mina = int.Parse(Console.ReadLine());
        Write("Escribe la hora B: ");
        int horb = int.Parse(Console.ReadLine());
        Write("Escribe los minutos B: ");
        int minb = int.Parse(Console.ReadLine());

        timeOfFlight(hora, mina, horb, minb);
    }
}