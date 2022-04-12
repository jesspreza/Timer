using System;
using System.Threading;

namespace Timer
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Console.WriteLine("Type a number and 'm' for minute(s) or 's' for second(s) as the exemple below:");
      Console.WriteLine("For 10 minuts type: 10m");
      Console.WriteLine();
      Console.Write("Set the timer for: ");
      string value = Console.ReadLine().ToLower();
      char minOrSec = char.Parse(value.Substring(value.Length - 1, 1));
      int time = int.Parse(value.Substring(0, value.Length - 1));
      int multiplier = 1;

      if (minOrSec == 'm')
        multiplier = 60;

      PreStart();  
      Start(time * multiplier);
      Console.WriteLine("Timer's end!");

    }
    static void PreStart()
    {
      Console.WriteLine("Ready...");
      Thread.Sleep(2500);
      Console.WriteLine("Go!");
      Thread.Sleep(1000);
      Console.Clear();    
    }
  
    static void Start(int time)
    {
      while (time >= 0)
      {
        Console.WriteLine(time);
        time--;
        Thread.Sleep(1000);
        Console.Clear();
      }
    }
  }
}
   