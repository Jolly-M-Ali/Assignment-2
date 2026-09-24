using System.Drawing;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1 - Write a program that takes a number from the user then print yes if
            //            that number can be divided by 3 and 4 otherwise print no.


            //Another way to write the same logic using if-else statement


            // 2 - Write a program that allows the user to insert an integer then print
            // negative if it is negative number otherwise print positive.


            //another way

            //if (number2 < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else
            //{
            //    Console.WriteLine("Positive");
            //}

            //3- Write a program that takes 3 integers from the user then prints the max
            //element and the min element.

            //Console.WriteLine("Enter 3 numbers: ");
            //int number3 = Convert.ToInt32(Console.ReadLine());

            #region Q20
            //20- Write a program in C# Sharp to find the sum of all elements of the array.
            int [] numbers = { 1, 2, 3, 4, 5 };
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            Console.WriteLine("Sum of array elements: " + sum);
            #endregion  
            #region q21
            //21 - Write a program in C# Sharp to merge two arrays of the same size
            //     sorted in ascending order.

            int[] array1 = { 1, 3, 5 }; 
            int[] array2 = { 2, 4, 6 };
            int[] MergedArray =array1.Concat(array2).OrderBy(x => x).ToArray();
            Console.WriteLine("Merged and Sorted Array:");
            foreach (int n in MergedArray)
            {
                Console.Write(n + " "); //  1 2 3 4 5 6
            }
            #endregion
            #region q22
            //22 - Write a program in C# Sharp to count the frequency of each element of
            //     an array.


            #endregion

            #region q23
            //23- Write a program in C# Sharp to find maximum and minimum element in an array
            #endregion

            #region q24

            //24- Write a program in C# Sharp to find the second largest element in an array.

            #endregion

            #region q27

            //27- Write a program to create two multidimensional arrays of same size.
            //Accept value from user and store them in first array. Now copy all the
            //elements of first array on second array and print second array.

            #endregion
            #region q28

            //28- Write a Program to Print One Dimensional Array in Reverse Order
            int[] array = { 10, 20, 30, 40, 50 };  
            Console.WriteLine("reverse order of the array:");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }   

            #endregion

        }
    }
}
