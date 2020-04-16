using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is a mad lib game! The user fills in the blanks to create a story using C# and the dotnet terminal.
      Author: Rutger McKenna
      */


      // Let the user know that the program is starting:


      // Give the Mad Lib a title:
      string title = "A Morning To Remember";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.Write("Enter a name: ");
      string name = Console.ReadLine();
      
      Console.Write("Enter your first adjective: ");
      string adj1 = Console.ReadLine();
      
      Console.Write("Enter another adjective: ");
      string adj2 = Console.ReadLine();
      
      Console.Write("Enter yet another adjective: ");
      string adj3 = Console.ReadLine();
      
      Console.Write("Enter a verb: ");
      string verb1 = Console.ReadLine();
      
      Console.Write("Enter a noun: ");
      string noun1 = Console.ReadLine();
      
      Console.Write("Enter another noun: ");
      string noun2 = Console.ReadLine();
      
      Console.Write("Now give me an animal: ");
      string animal = Console.ReadLine();
      
      Console.Write("And how about a food: ");
      string food = Console.ReadLine();
      
      Console.Write("And now give me a fruit: ");
      string fruit = Console.ReadLine();
      
      Console.Write("Give me a superhero: ");
      string superhero = Console.ReadLine();
      
      Console.Write("How about a country: ");
      string country = Console.ReadLine();
      
      Console.Write("And now give me a dessert: ");
      string dessert = Console.ReadLine();
      
      Console.Write("Finally, give me a year: ");
      string year = Console.ReadLine();
      

      // The template for the story:
      Console.WriteLine("Welcome to Mad Libs! Ready to play?");
      string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb1} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}
