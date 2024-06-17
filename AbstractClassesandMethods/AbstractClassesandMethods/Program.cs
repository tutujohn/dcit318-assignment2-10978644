using System;

namespace AbstractClassesAndMethods
{
    // Abstract class Shape
    public abstract class Shape
    {
        // Abstract method GetArea
        public abstract double GetArea();
    }

    // Derived class Circle
    public class Circle : Shape
    {
        // Fields
        private double radius;

        // Constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Implementing GetArea method for Circle
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        // Fields
        private double width;
        private double height;

        // Constructor
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Implementing GetArea method for Rectangle
        public override double GetArea()
        {
            return width * height;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of Circle and Rectangle
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);

            // Displaying their areas
            Console.WriteLine($"Area of Circle with radius 5: {circle.GetArea():F2}");
            Console.WriteLine($"Area of Rectangle with width 4 and height 6: {rectangle.GetArea():F2}");

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
