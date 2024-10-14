/*
それでは、3 つのオーバーロードを持つ IntroduceFriends() というメソッドを作成して、独自のオーバーロードを実装する練習をしてみましょう。

まず、2つの文字列引数を取るメソッド IntroduceFriends() を書きます。

このメソッドを

IntroduceFriends(「Laika」, 「Albert」)；

のように呼び出すと、コンソールに名前を含むメッセージが表示されるはずだ：

私の友達、ライカとアルバートです！

チェックポイント2 ステップ指示は、前のステップが完了するまで使用できません。
2.
次に、3つの文字列引数を取る別のメソッド IntroduceFriends() を書きます。それを呼び出すと

IntroduceFriends(「Naomi」, 「Jasmine」, 「Cyrus」)；

のように、コンソールに名前を含むメッセージが表示されるはずだ：

私の友達、ナオミ、ジャスミン、サイラスです！

チェックポイント3 ステップ指示は、前のステップが完了するまで使用できません。
3.
引数 0 の 3 番目の IntroduceFriends() メソッドを追加します。これを呼び出すと

を呼び出します；

を呼び出すと、全員がお互いを知っているので、誰も紹介する必要はありません！のようなメッセージを表示する：

紹介が必要な人はいません。

チェックポイント4 前のステップが完了するまで、ステップ指示は利用できない
4.
Main()の中で、各メソッドのオーバーロードを1回呼び出す。
*/


using System;

namespace MethodOverloading
{
  class Program
  {
    static void Main(string[] args)
    {
      IntroduceFriends("Laika", "Albert");
      IntroduceFriends("Naomi", "Jasmine", "Cyrus");
      IntroduceFriends();
    }

    static void IntroduceFriends(string friend1, string friend2)
    {
      System.Console.WriteLine($"These are my friends, {friend1} and {friend2}!");
    }
    static void IntroduceFriends(string friend1, string friend2, string friend3)
    {
      System.Console.WriteLine($"These are my friends, {friend1}, {friend2}, and {friend3}!");
    }
    static void IntroduceFriends()
    {
      System.Console.WriteLine($"There is no one who needs to be introduced.");
    }

  }
}
