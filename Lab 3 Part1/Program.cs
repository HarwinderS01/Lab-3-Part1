using System;

abstract class Animal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Age { get; set; }

    public abstract void Eat();

    public void DisplayProperties()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Colour: {Colour}");
        Console.WriteLine($"Age: {Age}");
    }
}

class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Dogs eat meat.");
    }
}

class Cat : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Cats eat mice.");
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a dog name: ");
        string dogName = Console.ReadLine();

        Dog dog = new Dog();
        Console.Write("Enter a dog colour: ");
        dog.Colour = Console.ReadLine();
        Console.Write("Enter a dog age: ");
        dog.Age = Convert.ToInt32(Console.ReadLine());
        dog.Name = dogName;
        Console.WriteLine("Dog properties:");
        dog.DisplayProperties();
        dog.Eat();

        Console.Write("Enter a cat name: ");
        string catName = Console.ReadLine();

        Cat cat = new Cat();
        Console.Write("Enter a cat colour: ");
        cat.Colour = Console.ReadLine();
        Console.Write("Enter a cat age: ");
        cat.Age = Convert.ToInt32(Console.ReadLine());
        cat.Name = catName;
        Console.WriteLine("Cat properties:");
        cat.DisplayProperties();
        cat.Eat();
        Console.WriteLine("Press Enter to close...");
        Console.ReadLine();
    }
}