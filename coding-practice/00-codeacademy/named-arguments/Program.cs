/*
VisitPlanets()メソッドには新しいオプション・パラメータがいくつかある。

まず、Main()の中で引数なしでメソッドを呼び出す。

チェックポイント 2 前のステップが完了するまで、ステップ指示は使用できません。
2.
再度メソッドを呼び出すが、numberOfPlanets のみを名前付き引数として値 2 で渡す。

チェックポイント3 前のステップが完了するまで、ステップ命令は利用できない。
3.
このメソッドをもう1度呼び、今度はnumberOfPlanetsに値2、nameに自分の名前を渡す。どちらの引数も名前で渡す。
*/


using System;

namespace NamedArguments
{
  class Program
  {
    static void Main(string[] args)
    {
    VisitPlanets();
    VisitPlanets(numberOfPlanets: 2);
    VisitPlanets(numberOfPlanets: 2, name: "momochico");
    }

    static void VisitPlanets(
      string adjective = "brave",
      string name = "Cosmonaut",
      int numberOfPlanets = 0,
      double gForce = 4.2)
    {
      Console.WriteLine($"Welcome back, {adjective} {name}.");
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
      Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
    }
  }
}

