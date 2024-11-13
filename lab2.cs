using System;
namespace lab2;
class Calculator
{
  public void add(int x, int y)
  {
    int sum = x + y;
    Console.WriteLine($"The sum of {x} and {y}={sum}");
  }

  public void add(int x, int y, int z)
  {
    int sum = x + y + z;
    Console.WriteLine($"The sum of {x}, {y} and {z}={sum}");
  }
  static void main(string[] args)
  {
    Calculator calc = new Calculator();
    calc.add(5, 7);
    calc.add(5, 7, 9);
  }
}