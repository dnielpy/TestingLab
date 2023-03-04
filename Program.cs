using System;

class Program
{
    static void Main(){
        static void devuelveTexto(string a, string b){
            // Este contador es para definir que valores tomarán las variables ext1 y ext2 
            bool contador = false;

            //Estos son los valores que se imprimen, el texto se les asigna en el condicional mas abajo
            string first;
            string second;

            //Contar los caracteres de los textos introducidos x el user
            int ext1 = a.Length;
            int ext2 = b.Length;

            //Si la extension de 1 > que la extension de 2 entonces contador = true           
            if (ext1 > ext2 ){
                contador = true;
            }

            //Si el contador = true first = primer texto introducido x el user
            if (contador == true)
            {
                first = a;
                second = b;
            }
            else {      //si no, bueno lo contrario
                first = b;
                second = a;
             }

            //Imprimir los textos
            Console.WriteLine($"{first} {second}");
        } 


    Console.WriteLine("Escribe 2 textos a continuación e imprimiré una cadena donde el primero sea el mayor: ");
    string text1 = Console.ReadLine();
    string text2 = Console.ReadLine();

    devuelveTexto(text1, text2);
    }
}