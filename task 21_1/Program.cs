using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;

namespace task_21_1
{
    class Student
    {
        private string name; //field
        private int age; //field
        private int studentId; //field
        public string Name //Property
        {
            get //read data
            {
                return name;
            }
            set //write data
            {
                name = value;
            }
        }
        public int Age //Property
        {
            get//read data
            {
                return age;
            }
            set //check on the value before assign it the private field 
            {
                if (value < MinAge || value > MaxAge)
                {
                    age = 15;
                }
                else
                {
                    age = value;
                }
            }
        }
        public int StudentId //Property
        {
            get //read data
            {
                return studentId;
            }
            set //write data
            {
                studentId = value;
            }
        }

        public string Email { get; set; } //Property

        public const int MinAge = 18 ; // constant field
        public const int MaxAge = 40; // constant field

        public Student(string Name , int Age , int StudentId , string Email) // conatracter with parameter
        {
            this.Name = Name; //pass the value to the property
            this.Age = Age; //pass the value to the property
            this.StudentId = StudentId; //pass the value to the property
            this.Email = Email; //pass the value to the property
        }
        

        
        public void GetDetails() // dispaly the data of object

        {
            Console.WriteLine($"{this.Name},{this.StudentId},{this.Age},{this.Email}");
        }

        ~Student() // destroucter 
        {
            Console.WriteLine("Done");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Sally",44,12,"sally@gmail.com");
            student.GetDetails();
        }
    }

    //1-	What is class
    //class is a template or blueprint that conatine members (fields and methods) 
    //2-	What is object
    //an instance of class , we can access the class prperties and methodes from object 
    //3-	Difference between class && object
    // the class is the properties and behavior , the object is the actual implementation for the class
    // class ia a template , object is an instance 
    //4-	Mention the OOP Principles
    // encapsulation , abstraction , Polymorphism , Inheritance 
    //5-	What is property 
    // a way to deal the a private field in class which control the access to it , using set and get methods 
    //6-	What is field 
    // it's a variable declared inside a class.
    //7-	What is constructor 
    //  a special method in a class Its main purpose is to initialize the object's fields
    //8-	What is encapsulation
    // mechanism that combines data and methods into a single unit called a class, It's a way to organize and protect your data and methods

}
