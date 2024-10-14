/*
前の演習で扱った Grow() メソッドを見てみましょう。

メソッド本体内で使用されている各インスタンス変数について、this キーワードを追加して、インスタンス変数を参照していることを指定します。

注：説明の例と同様に、ここにthisを追加しても、コードがどのように動作するかは変わりません。
*/

using System;

namespace ThisKeyword
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.name = "Congo";
      f.trees = 0;
      f.age = 0;
      f.biome = "Tropical";

      Console.WriteLine(f.name);
    }
  }
}
