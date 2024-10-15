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

namespace OverloadingConstructors
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest("Rendlesham");
      f.trees = 0;
      f.biome = "bio";

    }
  }
}
