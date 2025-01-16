using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1-	Create console application that read string from user and print the same string
            Console.WriteLine("enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("your Name is " + name);


            //2-	Define variables with kind of a.Double b.String c.Char d.Bool e.Int f.Const Then display it in console application

            double d = 1.44;
            string s = "sally";
            char c = 'a';
            bool b = false;
            int x = 2;
            const int y = 4;
            Console.WriteLine(d);
            Console.WriteLine(s);
            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine(x);
            Console.WriteLine(y);

            //3-	Define array with name car that hold more than 3 kinds on cars, then print all the cars with the array length.

            string[] car = { "Volov", "BMW", "Toyota" };
            for (int i = 0; i < car.Length; i++) {
                Console.WriteLine(i+"-"+car[i]);
            }

            /*4-	Write a program in C that reads a first name, Lastname and year of birth and display the names and the year one after another sequentially. Go to the editor
                    •	Input your firstname: Sami
                    •	Input your lastname: Ali
                    •	Input your year of birth: 1999
                    •	Sami Ali 1999
                    */
            Console.WriteLine("enter your First name:");
            string Fname = Console.ReadLine();
            Console.WriteLine("enter your Lats name:");
            string Lname = Console.ReadLine();
            Console.WriteLine("enter your year of birth:");
            string DOB = Console.ReadLine();
            Console.WriteLine(Fname + " " +Lname + " " +DOB);

            //5 - Write a program in C # to store elements in an array and print it


            //Console.WriteLine("nput element ");
            //string input = Console.ReadLine();
            //int ele = Convert.ToInt32(input);
            //int[] number = new int[ele];
            //for (int i = 0; i < ele; i++) {
            //    if (i == 0) {
            //        number[0] = 1;
            //    }
            //    else{
            //        number[i] = i;
            //    }
            //    Console.WriteLine(number[i]);
            //}
            string[] number = new string[10];
            ;
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"element - {i} : ");
                number[i] = Console.ReadLine();
            }
            foreach (string element in number)
            {
                Console.Write(element + " ");
            }
        }
    }
}
