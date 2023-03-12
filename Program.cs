using System;

class Program
{
    static void Main(){

        //Imlementar un metodo que devuelva el mayor de un array
        static int Mayor(int[] array){
            int maxValue = 0;
            for (int i = 0; i < array.Length; i++)
            {
                maxValue = Math.Max(array[i], maxValue);
            }
            System.Console.WriteLine(maxValue);
            return 0;
        }
        int[] miArray = {1,20,3,4,5};
        Mayor(miArray);


    }
}