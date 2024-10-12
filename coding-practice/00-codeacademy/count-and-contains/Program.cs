/*
1.
マラソン・リストが初期化されました。コンソールに Count を表示してください。

チェックポイント2 前のステップが完了するまで、ステップ指示は使用できません。
2.
2000年のシドニーオリンピックで、高橋尚子選手が143.23分（2012年のロンドンオリンピックまでオリンピック記録）のタイムで優勝しました。

Add() を使って、その値をリストに追加する。

チェックポイント 3 前のステップが完了するまで、ステップ指示は利用できない
3.
143.23 がリストに追加されたことを確認します。Contains() メソッドを呼び出して、返された値をコンソールに表示する。

チェックポイント4 ステップ命令は、前のステップが完了するまで使用できません。
4.
Countをもう一度表示する。5 に増えていることを確認します！
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

      marathons.Add(143.23);

      Console.WriteLine(marathons.Count);
      Console.WriteLine(marathons.Contains(143.23));
    }
  }
}
