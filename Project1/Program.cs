/// Chapter No. 13 - Homework6_Part_1
/// File Name: homework6.java
/// @author: Rossana Palma
/// Date:  October 3, 2021
///
/// Problem Statement: Write a program that creates an array with 10 items in it and creates a copy of it 
/// of the same length and then place the values in the copy.
/// 
/// Overall Plan:
/// 1) Create an array with 10 items
/// 2) Create a second array with same length and empty
/// 3) Use for loop read values from the original array and place them in the second array
/// 4) Display the contents of both arrays




using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 10;

            //Create initial array
            int[] initialArray = new int[SIZE] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            //Second array: same length as the first and empty
            int[] copyArray = new int[initialArray.Length];

            //Use a loop to read values from the original array and place them in the new array.
            for(int i = 0; i <initialArray.Length; i++)
            {
                copyArray[i] = initialArray[i];

                //Print out the contents of both arrays
                
                Console.Write("\tCopy array: ");
                Console.Write(copyArray[i] + " ");
                Console.Write("\tInitial array: ");
                Console.WriteLine(initialArray[i] + " ");
            }

                      
        }
    }
}
