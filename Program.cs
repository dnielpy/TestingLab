using System;
using System.Diagnostics;

class Program
{
    static void Main(){

        int agrego = 0;

        static void Write(string texto){
            Console.WriteLine(texto);
        };

//Minutes Of Flight
        static int minutesOfFlight(int MinA, int MinB){          
            int minutes = (60 - MinA) + MinB;
            return minutes;
        }

//Hours Of Flights
        static int hoursOfFlights(int HourA, int HourB, int agrego){
            int hour = Math.Max(HourA, HourB) - Math.Min(HourA, HourB) + agrego;
            return hour;
        }

//Time Of Flight
        static string timeOfFlight(int horas, int minutos){
            if (minutos == 60)
            {
                minutos = 60 - minutos;
            } 
            if (horas == 0){
                horas = 23;
            }
            string time = $"{horas}:{minutos}";
            return time;
        }

        Write("Escribe la hora A: ");
        int hora = int.Parse(Console.ReadLine());
        Write("Escribe los minutos A: ");
        int mina = int.Parse(Console.ReadLine());
        Write("Escribe la hora B: ");
        int horb = int.Parse(Console.ReadLine());
        Write("Escribe los minutos B: ");
        int minb = int.Parse(Console.ReadLine());

        if (minutesOfFlight(mina, minb) > 60){
            agrego++;
        }

        Console.WriteLine(timeOfFlight(hoursOfFlights(hora, horb, agrego), minutesOfFlight(mina, minb)));
    }
}