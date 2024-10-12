/*
Switch文を使う

この演習では、与えられたソースコードを変更しないでください！ですから、コードを追加するだけで、指示がない限りは変更しないでください！



整数値に基づいて曜日を印刷するための if-else 構造を置き換えるために switch 文を使用して単純な C# プログラムを作成します。

警告

デフォルト文字列の実行結果は、次のようになります：

「水曜日」

上記の 「Solution Explanation 」タブは、3回目の失敗でロックが解除されます。そこにこの練習問題の解答があるはずです。しかし、まずは自分で解いてみてください！

私たちはあなたを信じています💕。*/


// 以下のif-elseコードをswitch文を使ってC#で書き直しなさい。
int day = 3;

// TODO: Rewrite this if-else structure using a switch statement.
// if (day == 1)
//   Console.WriteLine("Monday");
// else if (day == 2)
//   Console.WriteLine("Tuesday");
// else if (day == 3)
//   Console.WriteLine("Wednesday");
// else
//   Console.WriteLine("Another day");

switch (day)
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  default:
    Console.WriteLine("Another day");
    break;
}
