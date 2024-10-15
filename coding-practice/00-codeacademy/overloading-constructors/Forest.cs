/*
Forestクラスの2番目のコンストラクタを定義する：

このコンストラクターは1つのパラメーター、nameを取る。
最初の引数にname変数、2番目の引数に 「Unknown 」を指定し、this()を使用する。
また、デフォルト値の使用に関するメッセージをコンソールに表示すること。
チェックポイント2 前のステップが完了するまで、ステップ命令は利用できない
2.
Program.cs の Main() 内で 2 番目のコンストラクタを呼び出し、「Rendlesham」 という名前の Forest オブジェクトを作成します。

チェックポイント 3 ステップ命令は、前のステップが完了するまで使用できません。
3.
コンストラクタ呼び出しの下で、この新しいインスタンスの biome フィールドを表示します。

このコードを実行すると、コンソールにメッセージと 「Unknown 」が表示されるはずです。なぜこの2つが表示されるのでしょうか？
*/

using System;
using System.Diagnostics.Contracts;

namespace OverloadingConstructors
{
  class Forest
  {
    public string name;
    public int trees;
    public int age;
    public string biome;
    public string str;

    public Forest(string name, string biome)
    {
      this.name = name;
      this.biome = biome;
      age = 1;
    }

    public Forest(string name) : this(name, "Unknown")
    {
      System.Console.WriteLine("Value defaulted to Unknown");
    }

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
