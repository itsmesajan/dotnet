using System;
public abstract class Animal
{
  public abstract void MakeSound();
  public void Sleep()
  {
    Console.WriteLine("Sleeping Zzz...");
  }
}

public class Dog : Animal
{
  public override void MakeSound()
  {
    Console.WriteLine("Woof!");
  }
}

public class Cat : Animal
{
  public override void MakeSound()
  {
    Console.WriteLine("Meow!");
  }
}

class program
{
  static void Main(string[] args)
  {
    Animal dog = new Dog();
    dog.MakeSound();
    dog.Sleep();

    Animal cat = new Cat();
    cat.MakeSound();
    cat.Sleep();
  }
}