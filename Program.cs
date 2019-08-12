/*
 * Name: Esther
 *C# app Car Class Activity.
 */

using System;

namespace CarMainDriver
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\t\tName: Esther\n");
            Console.WriteLine("\t\tWelcome to the Car Class Activity!");

            //instantiating a Car object.
            Car myCar2 = new Car();

            Console.WriteLine("\t\nCalling the acelerator method");
            for (int i = 0; i < 5; i++)
            {
                myCar2.accelerate();//the acelerator call
                Console.WriteLine("  {0}\tThe speed is: {1}",i, myCar2.speedMethod());
            }

            Console.WriteLine("\t\nCalling the break method");
            for (int i = 0; i < 5; i++)
            {
                myCar2.breakk();//the acelerator call
                Console.WriteLine("  {0}\tThe speed is: {1}", i, myCar2.speedMethod());
            }

            //instantiating another Car object.
            Car myCar1 = new Car()
            {
                year = 2000,
                make = "Toyota",
                speed = 5
            };
            Console.Read();
        }
    }
}
