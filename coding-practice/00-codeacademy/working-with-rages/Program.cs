/*
GetRange() を使用して、マラソン・リストの最初の 3 つの要素を取得する。

その結果を、topMarathons という新しいリスト変数に格納します。

チェックポイント 2 前のステップが完了するまで、ステップ命令は使用できません。
2.
topMarathons リストをループし、各値をコンソールに表示します。
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

      List<double> topMarathons = marathons.GetRange(0,3);
      foreach (double marathon in topMarathons){
        Console.WriteLine(marathon);
      }
    }
  }
}
