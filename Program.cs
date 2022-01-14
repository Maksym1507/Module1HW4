using System;

namespace Homework_4
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Enter count elements of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            string even = null;
            string odd = null;
            string alfabet = "abcdefghijklmnopqrstuvwxyz";
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 27);
            }

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    even += array[i] + " ";
                }
                else
                {
                    odd += array[i] + " ";
                }
            }

            string[] evenArray = new string[0];
            string[] oddArray = new string[0];

            if (even == null)
            {
                Console.WriteLine("No values in even array");
            }
            else
            {
                evenArray = even.Trim().Split(" ");
            }

            if (odd == null)
            {
                Console.WriteLine("No values in odd array");
            }
            else
            {
                oddArray = odd.Trim().Split(" ");
            }

            int countElementsToUpperInChetArray = 0;
            int countElementsToUpperInNechetArray = 0;

            for (int i = 0; i < evenArray.Length; i++)
            {
                evenArray[i] = alfabet[Convert.ToInt32(evenArray[i]) - 1].ToString();

                if (evenArray[i] == "d" || evenArray[i] == "h" || evenArray[i] == "j")
                {
                    evenArray[i] = evenArray[i].ToUpper();
                    countElementsToUpperInChetArray++;
                }
            }

            for (int i = 0; i < oddArray.Length; i++)
            {
                oddArray[i] = alfabet[Convert.ToInt32(oddArray[i]) - 1].ToString();

                if (oddArray[i] == "a" || oddArray[i] == "e" || oddArray[i] == "i")
                {
                    oddArray[i] = oddArray[i].ToUpper();
                    countElementsToUpperInNechetArray++;
                }
            }

            if (countElementsToUpperInChetArray > countElementsToUpperInNechetArray)
            {
                Console.WriteLine("Count elements with upper case in evenArray > oddArray");
            }
            else if (countElementsToUpperInChetArray < countElementsToUpperInNechetArray)
            {
                Console.WriteLine("Count elements with upper case in evenArray < oddArray");
            }
            else
            {
                Console.WriteLine("Count elements with upper case equals");
            }

            Console.Write("Array of even numbers: ");

            foreach (var item in evenArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.Write("Array of odd numbers: ");

            foreach (var item in oddArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}