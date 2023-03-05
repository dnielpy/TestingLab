using System;
using System.Diagnostics;

class Program
{
    static void Main(){
        static void biciesto(int x){
            if (x % 4 == 0 && x % 100 != 0)
            {
                Console.WriteLine("El año es biciesto");
                Environment.Exit(0);
            }
            if (x % 4 == 0 && x % 100 == 0 && x % 400 == 0)
            {
                Console.WriteLine("El año es biciesto");
                Environment.Exit(0);    //Para finalizar el programa
            }
            else
            {    
                Console.WriteLine("El año no es biciesto");
            }
        }
        System.Console.WriteLine("Escriba el año: ");
        int year = int.Parse(Console.ReadLine());
        biciesto(year);
        
    
    }
}