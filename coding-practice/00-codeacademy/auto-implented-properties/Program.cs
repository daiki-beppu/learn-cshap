/*
コード・エディターで、nameとtreeの基本的なフィールドとプロパティを定義しました。
現在のnameフィールドとNameプロパティを、自動実装されたNameプロパティで置き換えてください。

現在のツリーフィールドとツリープロパティを自動ツリープロパティに置き換える。
*/

using System;

namespace AutoImplementedProperties
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.Name = "Congo";
      f.Trees = 0;
      f.age = 0;
      f.Biome = "Tropical";

      Console.WriteLine(f.Name);
    }
  }
}
