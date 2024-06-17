using System;

namespace Interfaces
{
    // Define the IMovable interface
    public interface IMovable
    {
        void Move();
    }

    // Implementing class Car
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Implementing class Bicycle
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of Car and Bicycle
            Car myCar = new Car();
            Bicycle myBicycle = new Bicycle();

            // Calling Move() method on each instance
            myCar.Move();
            myBicycle.Move();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
