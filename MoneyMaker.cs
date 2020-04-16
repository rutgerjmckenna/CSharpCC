using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      
      Console.WriteLine("How much we workin' with here?");
      string ourTotal = Console.ReadLine();
      double totalDouble = Convert.ToDouble(ourTotal);
      
      Console.WriteLine($"{totalDouble} cents is equal to...");
      
      int gold = 10;
      int silver = 5;
      
      double goldCoins = Math.Floor(totalDouble / gold);
      double remainingGold = goldCoins % gold;
        
      double silverCoins = Math.Floor(remainingGold / silver);
      double remainingSilver = silverCoins % silver;
        
      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {remainingGold + remainingSilver}");
    }
  }
}
