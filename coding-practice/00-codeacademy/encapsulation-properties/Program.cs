/*
Forestクラス内で、nameフィールド用の基本的なNameプロパティを定義します。
ゲッターとセッターにはバリデーションはありません。

Forest.csで、nameフィールドをForestクラス内でのみアクセスできるように更新します。 Program.csで、フィールドf.nameの使用をプロパティf.Nameに置き換えます。

Forest.csに戻って、ゲッターとセッターを持つBiomeフィールドのBiomeプロパティを定義する。 セッターは3つの値のみを許可する： 「Tropical（熱帯）」、「Temperate（温帯）」、「Boreal（北方）」の3つの値のみを許可する。 それ以外の値を使用する場合は、biomeを「Unknown」に設定します。 biomeフィールドを更新し、Forestクラス内でのみアクセスできるようにします。 例えば、Program.csではこのようになります：
*/

using System;

namespace Properties
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.Name = "Congo";
      f.trees = 0;
      f.age = 0;
      f.Biome = "Desert";

      Console.WriteLine(f.Name);
      System.Console.WriteLine(f.Biome);
    }
  }
}
