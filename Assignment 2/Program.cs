using System.Xml.Linq;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1 - Write a program that takes a number from the user then print yes if
            //            that number can be divided by 3 and 4 otherwise print no.

            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            String result1 = number % 3 == 0 && number % 4 == 0 ? ("Yes") : ("No");
            Console.WriteLine(result1);
            //Another way to write the same logic using if-else statement
            if (number % 3 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            // 2 - Write a program that allows the user to insert an integer then print
            // negative if it is negative number otherwise print positive.

            Console.WriteLine("Enter number: ");

            int number2 = Convert.ToInt32(Console.ReadLine());


            String result = number2 < 0 ? ("Negative") : ("Positive");
            Console.WriteLine(result);
            //another way

            if (number2 < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Positive");
            }

            //3- Write a program that takes 3 integers from the user then prints the max
            //element and the min element.

            Console.WriteLine("Enter 3 numbers: ");
            int number3 = Convert.ToInt32(Console.ReadLine());




        }
    }
}
