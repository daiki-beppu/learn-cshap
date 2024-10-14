/*
前の演習で扱った Grow() メソッドを見てみましょう。

メソッド本体内で使用されている各インスタンス変数について、this キーワードを追加して、インスタンス変数を参照していることを指定します。

注：説明の例と同様に、ここにthisを追加しても、コードがどのように動作するかは変わりません。
*/

using System;

namespace ThisKeyword
{
  class Forest
  {
    public string name;
    public int trees;
    public int age;
    public string biome;

    public int Grow()
    {
      this.trees += 30;
      this.age++;

      return this.trees;
    }

    public int Burn()
    {
      trees -= 20;
      age++;
      return trees;
    }
  }
}

