using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace task_22_1
{
    class Vehicle
    {
        public string Brand  { get; set; }
        public string Model   { get; set; }

        public void start()
        {
            Console.WriteLine("Vehicle is starting.");
        }

        public void print() {
            Console.WriteLine($"{Brand},{Model}");
        }

    }

    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.Brand = "BMW";
            c1.Model = "2024";
            c1.NumberOfDoors = 2;
            c1.start();
            c1.print();
        }

        //What is constructor
        //A constructor is a special method in a class. where we gave a initial value.
        //What are the basic concepts of OOPs
        // encapsulation , abstraction , Polymorphism , Inheritance 
        //What is the Encapsulation
        // mechanism that combines data and methods into a single unit called a class, It's a way to organize and protect your data and methods
        //What is the sealed class
        //class that pervent inhertance from it 
        //What is the Inheritance concept
        // a class can inherit properties and behaviours (METHODS) from another class.

    }
}
