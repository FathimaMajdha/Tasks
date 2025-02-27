using System.Numerics;
using System;

namespace tasks_everyday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Check if a number is odd or even 
            int num = 10;
            if (num % 2 == 0)
            {
                Console.WriteLine("number is even"); 
            }
            else
            {
                Console.WriteLine("number is odd"); 
            }

            //2.Check if a number is Positive, Negative, or Zero. 
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

            //3. Find the largest of three numbers.
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


            //4. Find if a year is a leap year or not. 
            // 1.If the year is divisible by 4 and not divisible by 100 then print “leap year”. 
            // 2.Or if the year is divisible by 400 then print “leap year”. 
            // 3.Else print “not a leap year”.

            Console.Write("Enter a year:");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("not a Leap Year");

            }

            //5. Find the grade for input marks. 
             // 1.Print “S grade” if the mark is between 90 and 100.
             // 2.Print “A grade” if the mark is between 80 and 90.
             // 3.Print “B grade” if the mark is between 70 and 80.
             // 4.Print “C grade” if the mark is between 60 and 70.
             // 5.Print “D grade” if the mark is between 50 and 60.
             // 6.Print “E grade” if the mark is between 40 and 50.
             // 7.Print “Student has failed” if the mark is between 0 and 40.
             // 8.Else print “Invalid marks”

            Console.Write("Enter a Mark:");
            int mark = int.Parse(Console.ReadLine());
            if (mark >= 90 && mark <= 100)
            {
                Console.WriteLine("S grade");
            }
            else if (mark >= 80 && mark <= 90)
            {
                Console.WriteLine("A grade");
            }
            else if (mark >= 70 && mark <= 80)
            {
                Console.WriteLine("B grade");
            }
            else if (mark >= 60 && mark <= 70)
            {
                Console.WriteLine("C grade");
            }
            else if (mark >= 50 && mark <= 60)
            {
                Console.WriteLine("D grade");
            }
            else if (mark >= 40 && mark <= 50)
            {
                Console.WriteLine("E grade");
            }
            else if (mark >= 0 && mark <= 40)
            {
                Console.WriteLine("Student has failed");
            }
            else
            {
                Console.WriteLine("Invalid marks");
            }

            //star pattern 1
            int n = 5;
            for (int i = 1; i <= 5; i++)
            {
                string ptrn = "";
                for (int j = 1; j <= n - i; j++)
                {
                    ptrn += "  ";
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    ptrn += "* ";
                }
                Console.WriteLine(ptrn);
            }

            //inverted hollow pattern
            int n = 5;
            for (int i = n; i >= 1; i--)
            {
                string ptrn = "";
                for (int j = 1; j <= 2 * n - 1; j++)
                {
                    if (j == n - i + 1 || j == n + i - 1 || i == n)
                    {
                        ptrn += "* ";
                    }
                    else
                    {
                        ptrn += "  ";
                    }
                }
                Console.WriteLine(ptrn);
            }



            // character pattern
            for (int i = 1; i <= 5; i++)
            {
                string ptrn = "";
                for (int j = 1; j <= i; j++)
                {
                    ptrn += (char)(64 + j) + " ";
                }
                Console.WriteLine(ptrn);
            }


            //number pattern
            int k = 1;
            for (int i = 1; i <= 4; i++)
            {
                string row = "";
                for (int j = 1; j <= i; j++)
                {
                    row += k++ + " ";
                }
                Console.WriteLine(row);
            }


            //number pyramid pattern
            int n = 5;
            for (int i = 1; i <= 5; i++)
            {
                string ptrn = new string(' ', n - i);
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    ptrn += k;
                }
                Console.WriteLine(ptrn);
            }
        }
    }
}


        
