/*
C#のデザイナーは 「Anders Hejlsberg 」であり、彼の名前はdesignerという変数に格納されている。designerを引数としてConsole.WriteLine()を呼び出します。

チェックポイント2 前のステップが完了するまで、ステップ命令は利用できない
2.
では、アンダースの2番目の名前だけを表示してみよう。

まず、文字列デザイナーの中のスペース（「 」）のインデックスを探し、変数indexOfSpaceに格納します。

IndexOf()メソッドを使う必要があります。

チェックポイント3 前のステップが完了するまで、ステップ指示は利用できない
3.
スペース文字自体は2番目の名前の一部ではありません。

新しい整数 indexOfSecondName を作成し、indexOfSpace に 1 を加えた値でインスタンス化する。

チェックポイント4 前のステップが完了するまで、ステップ命令は使用できません。
4.
Substring() と変数 indexOfSecondName を使用して、2 番目の名前を取得する。

返された値を変数 secondName に格納する。このメソッドの使い方がわからない場合は、ドキュメントを参照してください。

チェックポイント 5 前のステップが完了するまで、ステップ指示は利用できない
5.
secondName をコンソールに出力します。
*/

using System;

namespace CallingMethods
{
  class Program
  {
    static void Main(string[] args)
    {
      string designer = "Anders Hejlsberg";
      Console.WriteLine(designer);

      int indexOfSpace = designer.IndexOf(" ");
      int indexOfSecondName = indexOfSpace + 1;

      string secondName = designer.Substring(indexOfSecondName, designer.Length - indexOfSecondName);

      Console.WriteLine(secondName);
    }
  }
}
