/*
1.
以前の演習で作成したVisitPlanets()メソッドがコード・エディタに用意されています。

既存のパラメーターを更新して、オプションにし、デフォルト値を 0 にします。

チェックポイント 2 前のステップが完了するまで、ステップ指示は使用できません。
2.
Main()内で、オプションのパラメータなしでメソッドを呼び出します。
*/

using System;

namespace OptionalParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets(3);
      VisitPlanets(4);
      VisitPlanets(5);
      VisitPlanets();
    }

    static void VisitPlanets(int numberOfPlanets = 0)
    {
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
    }
  }
}
