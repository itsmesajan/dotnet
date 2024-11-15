using System;
using Text;
namespace Text
{
  class Animal
  {
    public virtual void Eat()
    {
      Console.WriteLine("Animal is eat grass and flesh");
    }
  }
}

class Cow : Animal
{
  public override void Eat()
  {
    Console.WriteLine("Cow is eat grass only.");
  }

  static void Main(string[] args)
  {
    Cow obj = new Cow();
    obj.Eat();

    Animal obj1 = new Cow();
    obj1.Eat();
  }
}