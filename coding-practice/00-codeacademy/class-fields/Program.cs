/*
Forest.csで、Forestクラスに4つのフィールドを追加します。

文字列型のフィールドを2つ：

名前
生物群
int型のフィールド2つ

木
年齢
各フィールドの型宣言の前にpublicキーワードを含める。

注意：この時点で、コンパイラーはこれらのフィールドが宣言されているが値が割り当てられていないことを示す警告をいくつか投げます。次のステップで対処しますので、心配しないでください！

チェックポイント2 ステップ命令は、前のステップが完了するまで使用できません。
2.
Program.cs の Main() 内で、Forest オブジェクトがすでにインスタンス化されています。4つのフィールドにそれぞれ値を設定します。

チェックポイント3 ステップ命令は、前のステップが完了するまで使用できません。
3.
Main() で、name フィールドをコンソールに出力します。
*/

using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();

      f.name = "sugi";
      f.biome = "abc";
      f.trees = 3;
      f.age = 100;

      System.Console.WriteLine(f.name);
    }
  }
}
