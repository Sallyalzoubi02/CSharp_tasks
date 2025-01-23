using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6_23_1
{
    internal class Program
    {
        class Shape
        {
            public virtual void draw()
            {
                Console.WriteLine("shape");
            }
        }

        class Circle : Shape {
            public override void draw() {
                Console.WriteLine("circle");
            }
        }

        class Regtangle : Shape
        {
            public override void draw()
            {
                Console.WriteLine("Regtangle");
            }
        }
        class Calculator
        {
            public int Add(int a, int b) { return a + b; }
            public double Add(double a, double b) { return a + b; }
            public int Add(int a, int b , int c ) { return a + b + c; }
           

        }

        abstract class Animal
        {
            public abstract void makeSound();
            public void sleep()
            {
                Console.WriteLine("Animal is sleep");
            }
        }

        class Cat : Animal
        {
            public override void makeSound()
            {
                Console.WriteLine("cat sound meow");
            }

        }

        class Dog : Animal
        {
            public override void makeSound()
            {
                Console.WriteLine("dog sound bark");
            }

        }

        interface Playable
        {
            void play();
        }

        class Piano : Playable
        {
            public void play()
            {
                Console.WriteLine("Playing the piano.");
            }
        }

        class Guitar  : Playable
        {
            public void play()
            {
                Console.WriteLine("Playing the Guitar .");
            }
        }

        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(2,3));
            Console.WriteLine(calculator.Add(3,4,5)); 
            Console.WriteLine(calculator.Add(2.6,6.7)); 

            //------------------------------------------------------

            Regtangle regtangle = new Regtangle();
            Circle circle = new Circle();
            regtangle.draw();
            circle.draw();

            //------------------------------------------------------

            Cat cat = new Cat();
            cat.sleep();
            cat.makeSound();
            Dog dog = new Dog();
            dog.makeSound();
            dog.sleep();

            //------------------------------------------------------
            Guitar guitar = new Guitar();
            guitar.play();

            Piano piano = new Piano(); 
            piano.play();

        }
    }
}
