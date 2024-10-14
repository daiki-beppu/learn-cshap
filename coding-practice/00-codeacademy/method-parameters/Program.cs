/*
ここでは、VisitPlanets() メソッドを書き直した。

このメソッドに numberOfPlanets という int パラメータを追加します。

チェックポイント2 ステップ命令は、前のステップが完了するまで使用できません。
2.
パラメータを使うようにメソッド本体を変更する。もし誰かがあなたのメソッドを呼び出したら、いくつの惑星を訪問したかを表示するようにします。例えば、VisitPlanets(3) を呼び出すと、次のように表示されます：

あなたは3つの新しい惑星を訪問しました。

チェックポイント3 前のステップが完了するまで、ステップ命令は利用できない
3.
Main() の中で、引数を変えて VisitPlanets() を 3 回呼ぶ。
*/


using System;

namespace DefineParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0; i < 3; i++)
      {
        VisitPlanets(i + 3);
      }
    }

    static void VisitPlanets(int numberOfPlanets)
    {
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
    }
  }
}
