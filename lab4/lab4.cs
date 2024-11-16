using System;

namespace ConstructorDemo
{
  class MyClass
  {
    private int number;
    public MyClass()
    {
      Console.WriteLine("Default constructor is called.");
    }
    public MyClass(int number)
    {
      this.number = number;
      Console.WriteLine("Parameterized constructor is called Number = " + number);
    }

    private MyClass(string message)
    {
      Console.WriteLine("Private constructor is called. Message = " + message);
    }

    //Static method to exit the private constructor

    public static MyClass CreateInstance(string message)
    {
      return new MyClass(message);
    }

    class Program
    {
      static void Main(string[] args)
      {
        MyClass obj1 = new MyClass();
        MyClass obj2 = new MyClass(10);
        MyClass obj3 = MyClass.CreateInstance("Hello world!");
        Console.ReadLine();
      }
    }
  }
}