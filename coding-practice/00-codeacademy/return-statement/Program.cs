/*
惑星名を入力として受け取り、派手な歓迎メッセージを返す静的メソッドDecoratePlanet()を定義してみよう。

まず、メソッドの宣言を書く。文字列をパラメータとして持ち、文字列を返すようにします。

注：このステップでのビルドエラー、エラーCS0161は、このメソッドが文字列を返すべきなのに返していないことを通知しています。次のステップでは、必要な return 文をメソッドに追加します。

チェックポイント 2 前のステップが完了するまで、ステップ指示は使用できません。
2.
文字列の補間を使用して、惑星への歓迎を返すようにメソッド本体を記述する。例えば

を呼び出す；

を呼び出すと

「*.*.*火星へようこそ *.*.*」

チェックポイント3 ステップ命令は、前のステップが完了するまで使用できない
3.
引数 「Jupiter 」でメソッドを呼び出し、その出力をコンソールに表示する。
*/

using System;

namespace Return
{
  class Program
  {
    static void Main(string[] args)
    {
      System.Console.WriteLine(DecoratePlanet("Jupiter"));
      DecoratePlanet("Mars");
    }
    static string DecoratePlanet(string planetName)
    {
      return $"*.*.* Welcome to {planetName} *.*.*";
    }

  }
}
