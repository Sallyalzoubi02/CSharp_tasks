using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19_1
{
    internal class Program
    {
        static void dispalyName(string name)
        {
            string Fname = name.Substring(0,name.IndexOf(" "));
            string Lname = name.Substring((name.IndexOf(" ")+1));
            Console.WriteLine("The First name : " + Fname);
            Console.WriteLine("The Last name : " + Lname);
            Console.WriteLine(name.Length);
        }

        static void FindSmall(int n1 , int n2)
        {
            if (n1 < n2)
            {
                Console.WriteLine("smaller is :" + n1);
            }
            else
            {
                Console.WriteLine("smaller is :" + n2);
            }
        }
        static double KiloToMiles(double kilo)
        {
            return (kilo / 1.609);
        }

        static int Tominutes(int h , int m)
        {
            int min = h * 60 + m;
            return (min);
        }
        static string ToHoures(int m)
        {
            int h = Convert.ToInt32(m/60);
            int min = m%60;
            return ($" {h} hours,  {min} minutes");
        }

        static string ToHouresMin(int sec)
        {
            int h = sec / 3600;
            int min = (sec%3600) / 60;
            int s = sec % 60;
            return ($" {h} hours,  {min} minutes ,{s} seconds");
        }

        static string comparer(int n1 , int n2)
        {
            if(n1 < n2)
            {
                return "Smaller";
            }
            else if(n1 > n2)
            {
                return "Greater";
            }
            else
            {
                return "Equal";
            }
        }

        static int SumOfDigits(string s)
        {
            int sum =0;
            for (int i = 0; i < s.Length; i++)
            {
                int n = int.Parse(s[i].ToString());
                sum += n;
            }
            return (sum);
        }
        static string Reverse(string s)
        {
            string rev = "";
            for (int i = s.Length-1; i >= 0 ; i--)
            {
                
                rev += s[i];
            }
            return (rev);
        }

        static string divisible(int n,int n2)
        {
            if (n%n2 == 0)
            {
                return "divisible";
            }
            else
            {
                return "Not Divisible";
            }
        }

        static int Middle(int n1 ,int n2,int n3)
        {
            if (n2>n1 && n3>n2 || n2 > n3 && n1 > n2)
            {
                return n2;
            }
            else if (n1 > n2 && n3 > n1 || n1 > n3 && n2 > n1)
            {
                return n1;
            }
            else
            {
                return n3;
            }
        }
            static void Main(string[] args)
        {
           // //1-	Write a C# program that accepts a double input and converts it into an int. Display both values.
           // Console.WriteLine("Enter double");

           // double d = Convert.ToDouble(Console.ReadLine());
           // int i = (int) d;
           // Console.WriteLine("Double : "+d);
           // Console.WriteLine("int: "+i);

           ////2-	Write a program that uses a Convert.ToString() method to convert a number into a string and concatenate it with a sentence.

           // Console.WriteLine("Enter int");

           // int stat = int.Parse(Console.ReadLine());
           // Console.WriteLine($"Your number is: {stat.ToString()}");

           // //3-	Create a string with a sentence. Use ToUpper() and ToLower() to display the uppercase and lowercase versions of the string.
           // Console.WriteLine("Enter string");
           // string s= Console.ReadLine();
           // Console.WriteLine("Upper : " + s.ToUpper());
           // Console.WriteLine("lower : " + s.ToLower());

           // //4-	Write a program that takes a user's full name as input and prints:
           // //The first name.
           // //The last name.
           // //The length of the full name
           // Console.WriteLine("Enter Fullname");
           // string Fullname = Console.ReadLine();
           // dispalyName(Fullname);

           // //5-	Write a program that accepts two integers and prints the smaller of the two.
           // int num1 = 3;
           // int num2 = 5;
           // FindSmall(num1, num2);


           // //6-	  Write a method that converts kilometers per hour to miles per hour. Use this method in a program to convert and display the result.
           // Console.WriteLine("Enter kilometers");
           // double kilometers = double.Parse(Console.ReadLine());
           // Console.WriteLine(KiloToMiles(kilometers));

           // //7-	Write a method that takes hours and minutes as input and returns the total number of minutes.
           // Console.WriteLine("Enter hours");
           // int hours = int.Parse(Console.ReadLine());
           // Console.WriteLine("Enter minutes");
           // int minutes = int.Parse(Console.ReadLine());
           // Console.WriteLine($"The Total minutes : {Tominutes(hours, minutes)}");

           // //8-	Write a method that accepts minutes as input and calculates the total number of hours and minutes.
            
           // Console.WriteLine("Enter minutes");
           // int min = int.Parse(Console.ReadLine());
           // Console.WriteLine(ToHoures(min));

           // //9-	Compare Two Numbers Write a program that prints:
           // Console.WriteLine("Enter number1");
           // int n1 = int.Parse(Console.ReadLine());
           // Console.WriteLine("Enter number2");
           // int n2 = int.Parse(Console.ReadLine());
           // Console.WriteLine(comparer(n1,n2));

           // //10-   Write a program that calculates the sum of the digits of a number using arithmetic operators and loops (no conditionals).

           // Console.WriteLine("Enter number");
           // string n = Console.ReadLine();
           // Console.WriteLine(SumOfDigits(n));

           // //11-	Reverse a Number Write a program that reverses a number using arithmetic operators and loops.
           // Console.WriteLine("Enter number");
           // string num = Console.ReadLine();
           // Console.WriteLine(Reverse(num));


           // //12-   Write a program to check if a number is divisible by another number using logical and arithmetic operators.
           // ////Return a message "Divisible" or "Not Divisible".
           // ///
           // Console.WriteLine("Enter Two number");
           // int d1 = Convert.ToInt32(Console.ReadLine());
           // int d2 = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine(divisible(d1,d2));

            //13-   Write a program to find the middle value of three numbers using arithmetic and comparison operators.
            //Console.WriteLine("Enter Two number");
            //int d11 = Convert.ToInt32(Console.ReadLine());
            //int d22 = Convert.ToInt32(Console.ReadLine());
            //int d33 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Middle(d11, d22 ,d33));

            Console.WriteLine("Enter minutes");
            int sec = int.Parse(Console.ReadLine());
            Console.WriteLine(ToHouresMin(sec));

        }
    }
}
