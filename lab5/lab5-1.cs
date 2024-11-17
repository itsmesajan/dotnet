using System;

namespace InheritanceDemo
{
  // Base class
  class GrandParent
  {
    public void DisplayGrandParent()
    {
      Console.WriteLine("This is the GrandParent class.");
    }
  }

  // Derived class
  class Parent : GrandParent
  {
    public void DisplayParent()
    {
      Console.WriteLine("This is the Parent class.");
    }
  }

  // Another derived class (from Parent)
  class Child : Parent
  {
    public void DisplayChild()
    {
      Console.WriteLine("This is the Child class.");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Child childObj = new Child();

      // Access methods from all levels of the inheritance hierarchy
      childObj.DisplayGrandParent();
      childObj.DisplayParent();
      childObj.DisplayChild();

      Console.ReadLine();
    }
  }
}
