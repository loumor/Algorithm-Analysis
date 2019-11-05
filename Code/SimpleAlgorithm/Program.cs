using System;
namespace CAB301
{
    class SimpleAlgorithm
    {

        static void NegBeforePos(int[] array)
        {
            int val; 
            int j = array.Length - 1;
            int i = 0;
                       
            while (i <= j)
            {
                val = array[i];
                if (array[i] <= 0)
                {
                    i = i + 1;
                }
                else
                {
                    array[i] = array[j];
                    array[j] = val;
                    j = j - 1;
                }
            }

        }


        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }


        public static void Main(string[] args)
        {
            int Min = -100;
            int Max = 100;

            int[] arr = new int[7]; 

            Random randNum = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randNum.Next(Min, Max);
            }

            Console.Write("\nArray Before: ");
            printArray(arr);
            NegBeforePos(arr);
            Console.Write("\nArray After: ");
            printArray(arr);


        }
    }   
}



