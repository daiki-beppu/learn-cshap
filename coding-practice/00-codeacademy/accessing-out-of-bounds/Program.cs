/*
.
このコードには2つの問題がある。
使用するインデックスを変更することで、それぞれの誤ったステートメントを修正する。
*/

using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<double> marathons = new List<double>
      {
        144.07,
        143.12,
        146.73,
        146.33
      };

      double futureWinner = marathons[marathons.Count -1];
      System.Console.WriteLine(futureWinner);

      marathons.Add(143.23);

      Console.WriteLine("If you reached this point, there are no errors!");
    }
  }
}
