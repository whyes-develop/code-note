using System;

public class FizzBuzz
{
  static void fizzbuzz(UInt32 start, UInt32 end)
  {
    for (UInt32 number = start; number <= end; number++)
    {
      if (number % 15 == 0)
      {
        Console.WriteLine(number + ":FizzBuzz");
      }
      else if (number % 3 == 0)
      {
        Console.WriteLine(number + ":Fizz");
      }
      else if (number % 5 == 0)
      {
        Console.WriteLine(number + ":Buzz");
      }
      else
      {
        Console.WriteLine(number);
      }
    }
    
  }

  static public void Main()
  {
    fizzbuzz(1, 100);
  }
}