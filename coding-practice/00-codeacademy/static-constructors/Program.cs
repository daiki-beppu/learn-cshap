/*
これまでの練習では、forestsCreatedフィールドとforestFactsフィールドに開始値が与えられていませんでした！ まず、Forestの静的コンストラクタを作成します。

静的コンストラクタの本体で、forestFactsフィールドにこの文字列を設定する：

また、静的コンストラクタの本体内で、ForestsCreatedプロパティを0に設定する。

Program.cs で、Forest.PrintForestFacts() を呼び出して、ForestFacts プロパティが設定されていることを確認します。
*/

using System;

namespace StaticConstructors
{
  class Program
  {
    static void Main(string[] args)
    {

      Forest.PrintForestFacts();
    }
  }
}
