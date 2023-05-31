using System;

namespace constructorOverloading
{
    class Car
    {
        // constructor with no parameter
        Car()
        {
            Console.WriteLine("Car cosntructor");
        }

        //constructor with one parameter
        Car(string brand)
        {
            Console.WriteLine("Car constructo with one parameter");
            Console.WriteLine("Brand: " + brand);
        }

        Car(string brand, int price, int passengers)
        {
            Console.WriteLine("Car constructor with 3 parameters");
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Passengers: " + passengers);
        }

        static void Main(string[] args)
        {
            //call constructor with no parameter
            Car car = new Car();

            Console.WriteLine();

            //call constructor with parameter
            Car car2 = new Car("Bugatti");

            //car constructor with 3 parameters
            Car car3 = new Car("Ferrari", 20000, 2);

            Console.ReadLine();
        }
    }
}
