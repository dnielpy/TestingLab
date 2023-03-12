using System;
class Program
{
    static void Main(){
        static void arrayInverso(){
        System.Console.WriteLine("Escribe la cantidad de valores que tendrá el array: \n");
        int tamaño = int.Parse(Console.ReadLine());
        int[] miArray = new int[tamaño];
        int[] arrayInverso = new int[tamaño];
        int[] arrayInversoFinal = new int[tamaño]; 

        System.Console.WriteLine("\nAgrege los valores a continuacion: \n");
        for (int i = 0; i < miArray.Length; i++)
        {
            System.Console.WriteLine($"Valor {i} = ");
            int valores = int.Parse(Console.ReadLine());
            miArray[i] = valores;
        }
        int contador = 0;
        for (int j = 0; j < miArray.Length; j++)haber
            {
                contador++;
                arrayInverso[j] = miArray[tamaño - contador];
                arrayInversoFinal[j] = tamaño-contador;
               // Console.WriteLine($"Valor del array Inverso en la posicion {j}: {arrayInverso[j]}");
            }
            string miArrayString = string.Join(", ", arrayInverso);
            System.Console.WriteLine(miArrayString);
        }
        arrayInverso();
    }
}