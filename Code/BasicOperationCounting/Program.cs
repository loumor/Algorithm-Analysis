using System;
namespace BasicOperationCounting
{
    class Program
    {
        public static int basicOp; 

        static void NegBeforePos(int[] array)
        {
            int val; 
            int basicOperations = 0;
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
                    basicOperations++; //Increment Counter by 1
                    array[i] = array[j];
                    array[j] = val;
                    j = j - 1;
                }
            }

            basicOp = basicOperations; //Update the public variable 
            Console.WriteLine(basicOperations);

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
            int sizeOfArray = 0; // Holds the size of the array being tested
            int[] graphDataSize = new int[100]; // Stores Set Sizes
            int[] graphDataResults = new int[100]; // Stores Basic Operations 

            for (int i = 1; i < 86; i++) // Create 85 test cases 
            {
                sizeOfArray = i * 10; // Linear Growth
                int [] arr = randomGen(sizeOfArray); // Creates a random array with a size increasing by 10 each iteration
                Console.WriteLine("\nTest Case: " + i + " Set Size: " + sizeOfArray + " Number of Basic Operations: ");
                NegBeforePos(arr); // Run the algorithm
                graphDataSize[i-1] = sizeOfArray; // Storing Data
                graphDataResults[i-1] = basicOp; // Storing Data
            }

            for (int i = 86; i < 101; i++) // Create 15 test cases 
            {
                sizeOfArray = (sizeOfArray + 1) * 2; // Exponential Growth 
                int [] arr = randomGen(sizeOfArray); // Creates a random array with a size doubling for each iteration 
                Console.WriteLine("\nTest Case: " + i + " Set Size: " + sizeOfArray + " Number of Basic Operations: "); 
                NegBeforePos(arr); // Run the algorithm 
                graphDataSize[i-1] = sizeOfArray; // Storing Data 
                graphDataResults[i-1] = basicOp; // Storing Data
            }

            Console.WriteLine("Array Size : "+ string.Join(",", graphDataSize)); // Allows us to copy the sets sizes from the console
            Console.WriteLine("Number of Basic Operations : "+ string.Join(",", graphDataResults)); // Allows us to copy the number of 
            // operations from the console basic 


        }
    }   
}



