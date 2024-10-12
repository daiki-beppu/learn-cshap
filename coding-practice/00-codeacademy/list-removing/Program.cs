/*
マラソン・リストが初期化されました。リストの2番目の要素を印刷する。

チェックポイント2 前のステップが完了するまで、ステップ指示は使用できません。
2.
項目143.12（現在リストの2番目の項目）を削除し、その結果をremovedという名前のbool変数に格納する。

チェックポイント3 ステップ命令は、前のステップが完了するまで使用できない。
3.
2番目の要素と removed の値をもう一度表示する。2番目の要素は異なり、removedはtrueでなければならない。
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

      System.Console.WriteLine(marathons[1]);
      bool removed = marathons.Remove(143.12);
      System.Console.WriteLine(marathons[1]);
      System.Console.WriteLine(removed);

    }
  }
}
