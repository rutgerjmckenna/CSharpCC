using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
      string beginning = "I wish I was alone!";
      string middle = "I honestly think she might be crazy.";
      string end = "I can't wait to have my life back.";
      // Concatenate the string and the variables
      string story = beginning + " " + middle + " " + end;

      // Print the story to the console 
      Console.WriteLine(story);
    }
  }
}
