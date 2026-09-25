using System.Drawing;
using System.Linq;  
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1



            //1 - Write a program that takes a number from the user then print yes if
            //            that number can be divided by 3 and 4 otherwise print no.


            //Console.WriteLine("Enter a number: ");
            //string input = Console.ReadLine();
            //int number = Convert.ToInt32(input);

            //string result1 = number % 3 == 0 && number % 4 == 0 ? ("Yes") : ("No");
            //Console.WriteLine(result1);
            //Another way to write the same logic using if-else statement
            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            #endregion
            #region Q2


            // 2 - Write a program that allows the user to insert an integer then print
            // negative if it is negative number otherwise print positive.
            //Console.WriteLine("Enter number: ");

            //int number2 = Convert.ToInt32(Console.ReadLine());


            //string result = number2 < 0 ? ("Negative") : ("Positive");
            //Console.WriteLine(result);

            //another way

            //if (number2 < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else
            //{
            //    Console.WriteLine("Positive");
            //}
            #endregion
            #region Q3
            //3- Write a program that takes 3 integers from the user then prints the max
            //element and the min element.

            //Console.WriteLine("Enter 3 numbers: ");
            //string[] input = Console.ReadLine().Split();

            //int num1 = Convert.ToInt32(input[0]);
            //int num2 = Convert.ToInt32(input[1]);
            //int num3 = Convert.ToInt32(input[2]);

            //int max;
            //int min;

            //if (num1 > num2 && num1 > num3)
            //{
            //    max = num1;
            //}
            //else if (num2> num3)
            //{
            //    max = num2;
            //}
            //else
            //{
            //    max = num3;
            //}   
            //if (num1 < num2 && num1 < num3)
            //{
            //    min = num1;
            //}
            //else if (num2 < num3)
            //{
            //    min = num2;
            //}
            //else
            //{
            //    min = num3;
            //}   
            //Console.WriteLine("Max: " + max);   
            //Console.WriteLine("Min: " + min);
            #endregion
            #region Q4
            //4- Write a program that allows the user to insert an integer number then
            //check If a number is even or odd.

            //Console.WriteLine("Enter a number: ");
            //string input2 = Console.ReadLine();
            //int number= Convert.ToInt32(input2);  
            //if (number % 2 ==0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            // }
            #endregion
            #region Q5


            //5- Write a program that takes character from the user then if it is a
            //vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).

            //Console.WriteLine("Enter a character: ");
            //string input3 = Console.ReadLine();
            //char character = Convert.ToChar(input3.ToLower());  

            //if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            //    {
            //        Console.WriteLine("Vowel");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Consonant");
            //    }

            #endregion
            #region Q6
            //6 - Write a program that allows the user to insert an integer then print
            // all numbers between 1 to that number.


            //Console.WriteLine("Enter a number:”");

            //  string input = Console.ReadLine();

            // int num = Convert.ToInt32(input);

            //  for (int i = 1 ; i <= num ; i++)
            //{

            //    Console.WriteLine(i);
            //}

            #endregion
            #region Q7
            //7- Write a program that allows the user to insert an integer then

            //print a multiplication table up to 12.
            //Console.WriteLine("Enter A Number:");

            //string input = Console.ReadLine();

            //int num = Convert.ToInt32(input);



            //for (int i = 1; i <= 12; i++)
            //{
            //    int result = num * i;
            //    Console.WriteLine(result);

            //}

            #endregion
            #region Q8
            //Write a program that allows to user to insert number then print all
            //even numbers between 1 to this number


            //Console.WriteLine("Enter A Number:");

            //string input = Console.ReadLine();

            //int num = Convert.ToInt32(input);

            //for (int i = 1; i <= num; i++)
            //{

            //    if(i %2 ==0)
            //    {
            //        Console.Write(i + " ");
            //    }   

            //}
            #endregion

            #region Q9
            //9- Write a program that takes two integers then prints the power.
            //Console.WriteLine("Enter 2 Numbers:");


            //string[] input = Console.ReadLine().Split();

            //int num = Convert.ToInt32(input[0]);
            //int power = Convert.ToInt32(input[1]);
            //double result = Math.Pow(num, power);
            //Console.WriteLine(result);
            #endregion
            #region Q10

            //Write a program to enter marks of five subjects and calculate total ,average and percentage.


            //Console.WriteLine("Enter 5 Numbers:");  
            //string[] input = Console.ReadLine().Split();
            //int num1 = Convert.ToInt32(input[0]);
            //int num2 = Convert.ToInt32(input[1]);
            //int num3 = Convert.ToInt32(input[2]);
            //int num4 = Convert.ToInt32(input[3]);
            //int num5 = Convert.ToInt32(input[4]);

            //int total = num1 + num2 + num3 + num4 + num5;   
            //Console.WriteLine("Total: " + total);
            //int average = total / 5;    
            //Console.WriteLine("Average: " + average);
            //int percentage = (total * 100) / 500; // Assuming each subject has a maximum of 100 marks
            //Console.WriteLine("Percentage: " + percentage + "%");
            #region Q11

            //Write a program to input the month number and print the number of daysin that month.

            //Console.WriteLine("Enter the number of the month:");
            //string input = Console.ReadLine();
            //int num= Convert.ToInt32(input);
            //if (num == 2)
            //{

            //    Console.Write(28);

            //}

            //else if (num == 4 || num == 6 || num == 9 || num ==  11)
            //{

            //    Console.Write(30);

            //}
            //else
            //{

            //    Console.Write(31);

            //}

            #endregion

            #endregion
            #region Q12
            //Write a program to create a Simple Calculator.

            #endregion
            #region Q13

            #endregion
            #region Q14

            #endregion
            #region Q15

            #endregion
            #region Q16

            #endregion
            #region Q17

            #endregion
            #region Q18

            #endregion
            #region Q19

            #endregion

            //#region Q20
            ////20- Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int sum = 0;
            //foreach (int n in numbers)
            //{
            //    sum += n;
            //}
            //Console.WriteLine("Sum of array elements: " + sum);
            //#endregion  
            //#region q21
            ////21 - Write a program in C# Sharp to merge two arrays of the same size
            ////     sorted in ascending order.

            //int[] array1 = { 1, 3, 5 };
            //int[] array2 = { 2, 4, 6 };
            //int[] MergedArray = array1.Concat(array2).OrderBy(x => x).ToArray();
            //Console.WriteLine("Merged and Sorted Array:");
            //foreach (int n in MergedArray)
            //{
            //    Console.Write(n + " "); //  1 2 3 4 5 6
            //}
            //#endregion
            //#region q22
            ////22 - Write a program in C# Sharp to count the frequency of each element of
            ////     an array.


            //#endregion

            //#region q23
            ////23- Write a program in C# Sharp to find maximum and minimum element in an array
            //#endregion

            //#region q24

            ////24- Write a program in C# Sharp to find the second largest element in an array.

            //#endregion
            #region Q25

            #endregion
            #region Q26

            #endregion

            //#region q27

            ////27- Write a program to create two multidimensional arrays of same size.
            ////Accept value from user and store them in first array. Now copy all the
            ////elements of first array on second array and print second array.
            ///
            //int[,] arr0 = {{ 5,9,7 } , { 7,8,4} };
            //int[,] arr1 = { { 10, 20, 30 }, { 40, 50, 60 } };


            //#endregion
            //#region q28

            ////28- Write a Program to Print One Dimensional Array in Reverse Order
            //int[] array = { 10, 20, 30, 40, 50 };  
            //Console.WriteLine("reverse order of the array:");
            //for (int i = array.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(array[i] + " ");
            //}

            //#endregion


        }
    }
}
