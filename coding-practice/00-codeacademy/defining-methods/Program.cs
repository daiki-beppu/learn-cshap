/*
Main()メソッドの外にVisitPlanets()というメソッドを定義し、コードを実行する。

VisitPlanets()はコンソールに何でも表示できますが、「You visited many new planets... 」のようなものが適切でしょう。

チェックポイント2 ステップ命令は、前のステップが完了するまで使用できません。
2.
なぜメソッドが実行されないのですか？Main()内で呼び出されていません。Main()の中で呼び出して、もう一度コードを実行してください。
*/

using System;

namespace DefineAMethod
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets();
    }

    static void VisitPlanets()
    {
      System.Console.WriteLine("You visited many new planets...");
    }
  }
}
