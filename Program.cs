using System;
using System.Collections.Generic;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a number greater than 0.");
    string stringNumber = Console.ReadLine();
    int inputtedNumber = int.Parse(stringNumber);
    Console.WriteLine("--------------------");
    for (int index = 1; index <= inputtedNumber; index ++)
    {
      if ((index % 3 == 0) && (index % 5 == 0))
      {
        Console.WriteLine("Ping-Pong");
      }
      else if (index % 5 == 0)
      {
        Console.WriteLine("Pong");
      }
      else if (index % 3 == 0)
      {
        Console.WriteLine("Ping");
      }
      else
      {
        Console.WriteLine(index);
      }
    }
  }
}