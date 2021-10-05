/// Chapter No. 13 - Homework6_Part_2
/// File Name: homework6.java
/// @author: Rossana Palma
/// Date:  October 3, 2021
///
/// Problem Statement: Write a program to reverse an array. Use three methods: one to create the array, one to reverse the array, 
/// and one to print the array at the end. 
/// 
/// Overall Plan:
/// 1) Create GenerateNumbers method to create an array of 10 numbers
/// 2) Create Reverse method to reverse the array
/// 3) Create PrintNumbers method to print out the items in it.
/// 4) Invoke the methods in Main method
/// 5) Display results on the screen



using System;


namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            Reverse(numbers);
            PrintNumbers(numbers);

            Console.ReadLine();
        }
        static int[] GenerateNumbers()
        {   
            //Create an array using loop
            int[] array = new int[10];
            for(int i = 0; i < 10; i++ )
            {
                array[i] = i + 1;
            }
            return array; // return an array of 10 numbers
        }
        static void Reverse(int[] array)
        {
            //Use a for loop, starting at 0 and going up the length of the array / 2
            for (int i = 0; i < array.Length / 2; i++)
            {
                //place the value of one variable in a temporary location to make the swap
                int temp = array[i];
                array[i] = array[array.Length - i - 1];
                temp = array[array.Length - i - 1];
            }
        }

        static void PrintNumbers(int[] array)
           {
             foreach(int i in array)
                {
                    Console.WriteLine(i + " " );
                }
           }
    }
}
