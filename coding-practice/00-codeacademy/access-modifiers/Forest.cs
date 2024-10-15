/*
エディターでプログラムを見てみよう。
Program.csでは、新しいフォレスト・オブジェクトfを初期化し、Main()の中で木と年齢のフィールドを直接増やしています。
フィールドの値を更新する前と後の両方で、ヘルパー関数AnnounceForest()を呼び出し、フォレスト・オブジェクトに関する文字列をコンソールに表示しています。
プログラムをそのまま実行し、出力を観察してください。

Forest.csで、両方のプロパティを更新し、クラス定義の外からアクセスできないようにします。
注意：Main()のコードがアクセスできないものにアクセスしようとしているため、ターミナルでエラーが発生します。 次のステップでこのエラーに対処しますので、ご心配なく！

treesフィールドとageフィールドをprivateにしたため、Forestクラスの外部からはアクセスできなくなり、コードがエラーになっています！
これに対処するため、Forest.cs内で新しいメソッドGrow()の定義をすでに開始しています。
Program.csから木と年齢を更新する2行を削除し、Grow()メソッドの本体に追加します。
インスタンスfの代わりにインスタンス変数を参照するようにコードを調整します。Program.csのコードを削除した場所に、Grow()メソッドの呼び出しを追加します。
*/

namespace AccessModifiers
{
  class Forest
  {
    private string name;
    private int trees;
    private int age;
    private string biome;

    public Forest(string name, string biome)
    {
      this.name = name;
      this.biome = biome;
      age = 1;
    }

    public void Grow()
    {
      this.trees += 20;
      this.age++;
    }

    private void AnnounceForest()
    {
      Console.WriteLine($"The {name} {biome} Forest is {age} years old and has {trees} trees");
    }

  }

}
