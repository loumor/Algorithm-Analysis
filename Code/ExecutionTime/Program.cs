using System;
namespace ExecutionTime
{
    class ExecutionTime
    {
        public static long elapsedTime; //Store time for public access 

        static void NegBeforePos(int[] array)
        {
            int val; 
            int j = array.Length - 1;
            int i = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew(); //Start stopwatch
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
            watch.Stop(); //Stop Stopwatch
            elapsedTime = watch.ElapsedMilliseconds; //Save time to public variable 
        }


        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }

        static int[] randomGen(int size){
            int Min = -100;
            int Max = 100;

            int[] arr = new int[size]; 

            Random randNum = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randNum.Next(Min, Max);
            }
            return arr;
        }





        public static void Main(string[] args)
        {
            long[] graphSetSize = new long[50]; // Stores Set Sizes
            long[] graphTime = new long[50]; // Stores Time in Milliseconds

            for (int i = 0; i < 50; i++) // Create 50 test cases 
            {
                int sizeOfArray = i * 500000; // Linear Growth
                int [] arr = randomGen(sizeOfArray); // Creates a random array with a size increasing by 500000 each iteration
                NegBeforePos(arr); // Run the algorithm
                graphSetSize[i] = sizeOfArray; // Storing Data
                graphTime[i] = elapsedTime; // Storing Data

            }
            Console.WriteLine("Array Size : "+ string.Join(",", graphSetSize)); // Allows us to copy the sets sizes from the console
            Console.WriteLine ("Time in Milliseconds: "+ string.Join(",", graphTime)); // Allows us to copy execution time
                               
        }
    }   
}





