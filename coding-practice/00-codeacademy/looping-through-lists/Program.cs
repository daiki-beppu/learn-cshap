/*
コードの2番目のforループは、各走者のゼッケンをプリントアウトするために使われています。
同じ目的を達成するforeachループに置き換えてください。
*/

using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<string> runners = new List<string> { "Jemima Sumgong", "Tiki Gelana", "Constantina Tomescu", "Mizuki Noguchi" };
      Random rand = new Random();

      Console.WriteLine("In reverse chronological order, the gold medalists are...");

      // First loop
      for (int i = 0; i < runners.Count; i++)
      {
        Console.WriteLine($"{i + 1}: {runners[i]}");
      }

      Console.WriteLine("\nPrinting runner bibs...");

      // Second loop
      // for (int i = 0; i < runners.Count; i++)
      // {
      //   string name = runners[i].ToUpper();
      //   int id = rand.Next(100, 1000);
      //   Console.WriteLine($"{id} - {name}");
      // }

      foreach (string name in runners)
      {
        int id = rand.Next(100, 1000);
        Console.WriteLine($"{id} - {name.ToUpper()}");
      };
    }
  }
}
