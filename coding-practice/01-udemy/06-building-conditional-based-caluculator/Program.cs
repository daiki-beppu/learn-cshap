/*
条件付き電卓の構築

#########################################

この演習では、与えられたソースコードを変更しないでください！ですから、コードを追加するだけで、指示がない限り修正しないでください！
ユーザー入力に基づいて基本的な算術演算（+、-、*、/）を実行する簡単な C# 電卓プログラムを作成します。プログラムは次のようにします：

ユーザーに 2 つの数値を入力するよう促す。

ユーザーに算術演算（加算、減算、乗算、除算）の選択を促す。

条件文を使用して、選択した演算を実行する。

演算結果をコンソールに表示する。

ゼロによる除算を特定のメッセージで処理する。

警告

プログラムは、演算結果を正しく処理し、表示し、無効な演算とゼロによる除算を処理しなければならない。

EXTRA INFO！
テストコードは何を期待していますか？

テストコードは、あなたの電卓プログラムが特定のシナリオを正しく処理することを検証します。詳細は以下の通りです：



加算テスト：

入力： 5, 3, +

期待される出力

最初の数字を入力：
番目の数字を入力：
操作を選択する： +, -, *, /
結果: 8
ゼロによる除算テスト：

入力： 5, 0, /

期待される出力

最初の数字を入力：
2番目の数字を入力：
演算を選択する： +, -, *, /
エラー ゼロによる除算はできません。
無効な操作です：

入力してください： 5, 3, %

期待される出力

最初の数字を入力してください：
2番目の数字を入力してください：
演算を選択する： +, -, *, /
無効な操作です。または/を選択してください。


テストに合格するために、あなたのプログラムが与えられた入力に対してこれらの正確な出力を生成することを確認してください。

幸運を祈る！
*/
using System;

// TODO: Implement the calculator logic here
System.Console.WriteLine("Enter the first number:");
int firstNum = Int32.Parse(Console.ReadLine().Trim());

System.Console.WriteLine("Enter the second number:");
int secondNum = Int32.Parse(Console.ReadLine().Trim());
System.Console.WriteLine("Choose an operation: +, -, *, /");
string selectaAithmetic = Console.ReadLine().Trim();

int result = 0;

if (selectaAithmetic == "+")
{
  result = firstNum + secondNum;
  System.Console.WriteLine($"Result: {result}");
}
else if (selectaAithmetic == "-")
{
  result = firstNum - secondNum;
  System.Console.WriteLine($"Result: {result}");
}
else if (selectaAithmetic == "*")
{
  result = firstNum * secondNum;
  System.Console.WriteLine($"Result: {result}");
}
else if (selectaAithmetic == "/")
{
  if (firstNum == 0 || secondNum == 0)
  {
    System.Console.WriteLine("Error: Division by zero is not allowed.");
    return;
  }
  else
    result = firstNum / secondNum;
  System.Console.WriteLine($"Result: {result}");
}
else
{
  System.Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
}

