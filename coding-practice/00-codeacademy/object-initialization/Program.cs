/*
現在のコードでは、空のリストを作成し、Add()を使って要素を追加している。

これらの行を削除し、オブジェクトの初期化で同じリストを作成します。
*/

using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<double> marathons = new List<double> {
        144.07,
        143.12,
        146.73,
        146.33
      };

      // Do not delete the code below
      double time = marathons[1];

      Console.WriteLine($"The 2012 marathon was ran in {time} minutes!");

    }
  }
}
