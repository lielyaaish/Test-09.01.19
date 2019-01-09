using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Test answers! :) ");

            Console.Write("Enter a number: ");   // Question 1
            int i = Convert.ToInt32(Console.ReadLine());
            Mul2(i);

            int[] a = { 5, 4, -5 };   // Question 2
            Update(a);
            Console.WriteLine();
            Console.WriteLine($"The fixed Array is ({a[0]} , {a[1]}, {a[2]})");
            Console.WriteLine("The first number of the array has changed. ");

            int[] a2 = { 5, 4, -5 };  // Question 3
            Update2(a2);
            Console.WriteLine();
            Console.WriteLine($"The fixed Array is ({a2[0]} , {a2[1]}, {a2[2]})");
            Console.WriteLine("The first number of the array has NOT changed. ");
        }

        private static void Mul2(int i)  // Question 1
        {
            i = i * 2;
            Console.WriteLine($"Multiplay 2 of your number is {i}");
        }

        static void Update(int[] a)  //Question 2
        {
            a[0] = 1;
        }

        /*  Question 2 - ANSWER
        YES, the number will be changed
        The first number will stay on "1" because the Method is called
        after the the array is based.
        if the funcation will be before the int[] a = { 5, 4, -5 }
        Then nothing will happened. */

        static void Update2(int[] a2)  //Question 3
        {
            a2 = new int[3];
            a2[0] = 1;
        }
        /*  Question 3 - ANSWER
        No, the first number will NOT changed Because we created
        a new array in the funcation so the array has back to a new array */
    }
}
