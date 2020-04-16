using System;

namespace MakingProgress
{
  class Program
  {
    static void Main(string[] args)
    {
      // declare steps variable
      int steps = 0;

      // Two steps forward 
      int steps = steps += 2;

      // One step back 
      int steps = steps--;

      // Print result to the console
      Console.WriteLine(steps);
    }
  }
}
