using System;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 08 12 Class Inherence and Introduction to Lists");
            ListClasswork classwork = new ListClasswork();
            // classwork.ex1();
            // classwork.ex2();
            // classwork.ex3();
            // classwork.ex4();
            // classwork.ex5();

            Animal baseAnimal = new Animal();
            baseAnimal.animalSound();
            Cat catAnimal = new Cat();
            catAnimal.animalSound();
            Dog dogAnimal = new Dog();
            dogAnimal.animalSound();
        }
    }
}
