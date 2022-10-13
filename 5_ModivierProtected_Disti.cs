using System;

namespace MyApplication
{

    class Person
    {
        protected string name = "Disti";
    }

    // derived class
    class Program : Person
    {
        static void Main(string[] args)
        {

            // creating object of derived class
            Program program = new Program();

            // accessing name field and printing it
            Console.WriteLine("Name: " + program.name);
            Console.ReadLine();
        }
    }
}