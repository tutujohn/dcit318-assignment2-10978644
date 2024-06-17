using System;

namespace IInheritanceAndMethodOverriding
{
    // Base class
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            Console.WriteLine("Animal makes:");
            animal.MakeSound();

            Console.WriteLine("\nDog makes:");
            dog.MakeSound();

            Console.WriteLine("\nCat makes:");
            cat.MakeSound();

            // Keep the console window open until a key is pressed
            Console.ReadKey();
        }
    }
}
