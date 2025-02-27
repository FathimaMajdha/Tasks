using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System;
using System.Xml.Linq;
using System.Reflection.Metadata;
using System.Diagnostics;

namespace tasks_everyday
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 10;
            if (num % 2 == 0)
            {
                Console.WriteLine("number is even"); 
            }
            else
            {
                Console.WriteLine("number is odd"); 
            }


            int num1 = 10;
            if (num1 < 0)
            {
                Console.WriteLine("number is negative");
            }
            else if (num1 > 0)
            {
                Console.WriteLine("number is positive");
            }
            else
            {
                Console.WriteLine("number is zero");
            }


            int n1 = 7, n2 = 4,n3 = 5;
            int largest;
            if (n1 >= n2 && n1 >= n3)
            {
                largest = n1;
            }
            else if (n2 >= n1 && n2 >= n3)
            {
                largest = n2;
            }
            else
            {
                largest = n3;
            }
            Console.WriteLine($"largest number is  { largest}");


            //Console.Write("Enter a year:");
            //int year = int.Parse(Console.ReadLine());

            //if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            //{
            //    Console.WriteLine("Leap Year"); 
            //}
            //else
            //{
            //    Console.WriteLine("not a Leap Year");

            //}


            //Console.Write("Enter a Mark:");
            //int mark = int.Parse(Console.ReadLine());
            //if (mark >= 90 && mark <= 100)
            //{
            //    Console.WriteLine("S grade");
            //}
            //else if (mark >= 80 && mark <= 90)
            //{
            //    Console.WriteLine("A grade");
            //}
            //else if (mark >= 70 && mark <= 80)
            //{
            //    Console.WriteLine("B grade");
            //}
            //else if (mark >= 60 && mark <= 70)
            //{
            //    Console.WriteLine("C grade");
            //}
            //else if (mark >= 50 && mark <= 60)
            //{
            //    Console.WriteLine("D grade");
            //}
            //else if (mark >= 40 && mark <= 50)
            //{
            //    Console.WriteLine("E grade");
            //}
            //else if (mark >= 0 && mark <= 40)
            //{
            //    Console.WriteLine("Student has failed");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid marks");
            //}


            //int n = 5;
            //for (int i = 1; i <= 5; i++)
            //{
            //    string ptrn = "";
            //    for (int j = 1; j <= n - i; j++)
            //    {
            //        ptrn += "  ";
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        ptrn += "* ";
            //    }
            //    Console.WriteLine(ptrn);
            //}

            //int n = 5;
            //for (int i = n; i >= 1; i--)
            //{
            //    string ptrn = "";
            //    for (int j = 1; j <= 2 * n - 1; j++) 
            //    {
            //        if (j == n-i+1 || j == n+i-1 || i == n)
            //        {
            //            ptrn += "* ";
            //        }
            //        else
            //        {
            //            ptrn += "  ";
            //        }
            //    }
            //    Console.WriteLine(ptrn);
            //}


            for (int i = 1; i <= 5; i++)
            {
                string ptrn = "";
                for (int j = 1; j <= i; j++)
                {
                    ptrn += (char)(64 + j) + " ";
                }
                Console.WriteLine(ptrn);
            }



            //int k = 1;
            //for (int i = 1; i <= 4; i++)
            //{
            //    string row = "";
            //    for (int j = 1; j <= i; j++)
            //    {
            //        row += k++ + " ";
            //    }
            //    Console.WriteLine(row);
            //}



            //int n = 5;
            //for (int i = 1; i <= 5; i++)
            //{
            //    string ptrn = new string(' ', n - i);
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        ptrn += k;
            //    }
            //    Console.WriteLine(ptrn);
            //}
        }
    }
}
