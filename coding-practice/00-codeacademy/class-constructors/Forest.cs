/*
Forestクラスのコンストラクタを定義します。これは2つのパラメータを取る：

名前
生物群
コンストラクタ本体では、引数の値を同じ名前のインスタンス変数に代入する。また、age の値を 1 に設定する。

チェックポイント2 前のステップが完了するまで、ステップ命令は利用できない。
2.
Program.cs のコードはコメントアウトされています。コメントを外して実行してください。

エラーが表示されるはずです：

エラー CS7036：'Forest.Forest(文字列, 文字列)'の必須形式パラメータ'name'に対応する引数が指定されていません。

このエラーは、Program.csでパラメータなしのコンストラクタForest()を使用しているために発生します。コンストラクタForest(string, string)が定義されたため、これは機能しなくなりました。

チェックポイント 3 前のステップが完了するまで、ステップ命令が使用できません。
3.
Main() で新しいコンストラクタを呼び出し、名前「Congo」、バイオーム「Tropical」の Forest オブジェクトを作成します。

また、以下の行を削除してもよい：

f.name = 「Congo」；

そして

f.name = 「Congo」; and f.biome = 「Tropical」；

これらのフィールドはコンストラクタによって設定されるようになったので、もはや必要ない！
*/

using System;

namespace Constructors
{
  public class Forest
  {
    public string name;
    public int trees;
    public int age;
    public string biome;

    public Forest(string name, string biome)
    {
      this.name = name;
      this.biome = biome;
      this.age = 1;
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

