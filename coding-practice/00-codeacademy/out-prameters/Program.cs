/*
まず、outパラメータを利用する別の既存のメソッド、Double.TryParse()を使ってみましょう。

コード・エディタのプログラムでは、すでにscoreAsStringという変数が定義されていて、（100点満点の）スコアを文字列として保持しています。

まず、2つの変数を定義する：

outcomeというbool変数で、文字列がdoubleとしてパースに成功したかどうかを格納します。
scoreAsDouble という名前の double で、パースされた値を格納する。
チェックポイント 2 ステップ命令は、前のステップが完了するまで使用できません。
2.
次に、Double.TryParse() を呼び出して scoreAsString を double に変換し、scoreAsDouble を out 引数として渡します。関数呼び出しの結果を変数 outcome に保存します。

Double.TryParse() のシグネチャは次のようになります：

public static bool TryParse (string? s, out double result)；

チェックポイント3 ステップ命令は、前のステップが完了するまで使用できません。
3.
結果と scoreAsDouble をコンソールに出力する。

チェックポイント4 前のステップが完了するまで、ステップ命令は使用できません。
4.
では、outパラメータを使う独自のメソッドを作ってみよう！

Whisper()メソッドを宣言し、文字列パラメータとoutパラメータを指定する。このメソッドは文字列を返すはずです。

チェックポイント5 ステップ命令は、前のステップが完了するまで使用できない
5.
Whisper() は文字列引数の小文字を返すこと。

一度定義すれば、次のように呼び出せるはずだ：

string statement = 「Hello World」；
Whisper(statement, out bool marker)；
// 「Hello World 」を返し、markerをtrueに設定する；

チェックポイント6 前のステップが完了するまで、ステップ指示は利用できない
6.
Main() メソッドで Whisper() を呼び出し、文字列引数としてステートメントを渡す。

メソッドを呼び出すときは、必ず out 修飾子を使用してください！
*/

using System;

namespace OutParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      string scoreAsString = "85.6";
      string statement = "Hello World";

      bool outcome = false;
      double scoreAsDouble = 0;

      outcome = Double.TryParse(scoreAsString, out scoreAsDouble);
      System.Console.WriteLine($"outcome: {outcome},\nscoreAsDouble: {scoreAsDouble}");

      System.Console.WriteLine(Whisper(statement, out outcome));
    }

    static string Whisper(string phrase, out bool wasWhisperCalled)
    {
      wasWhisperCalled = true;
      return phrase.ToLower();
    }

  }
}
