// using system;

class Lab
{
  static void main()
  {
    //Demonstrating Console.writeLine()
    Console.WriteLine("This is Console.writeLine()");
    Console.WriteLine("It move the cursor to the next line after printing");

    // Demonstrating Console.write();
    Console.Write("This is Console.write()");
    Console.Write("It doesn't move the cursor to the next line.");
    Console.WriteLine();//Adding a new line

    //Demonstrating Console.ReadLine()
    Console.WriteLine("Press Enter a line of text(Console.readLine():)");
    string inputLine = Console.ReadLine();
    Console.WriteLine("You entered(using Console.ReadLine()): " + inputLine);

    //Demonstrating Console.Read()
    Console.WriteLine("Please enter a single character(Console.Read()):");
    int inputChar = Console.Read();
    Console.WriteLine("You entered  (using Console.Read()):" + (char)inputChar);

    Console.ReadKey();
  }
}