using System;

namespace InheritanceDemo
{
    // Interface 1
    interface IAnimal
    {
        void Eat();
    }

    // Interface 2
    interface IBird
    {
        void Fly();
    }

    // Class implementing both interfaces
    class Bat : IAnimal, IBird
    {
        public void Eat()
        {
            Console.WriteLine("Bat is eating.");
        }

        public void Fly()
        {
            Console.WriteLine("Bat is flying.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bat bat = new Bat();

            // Access methods from both interfaces
            bat.Eat();
            bat.Fly();

            Console.ReadLine();
        }
    }
}
