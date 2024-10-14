/*
Forest.csでクラスを定義し、Program.csのMain()メソッドでそのクラスを扱います。

名前空間 DefiningClasses 内で、Forest.cs に空の Forest クラスを作成します。

チェックポイント 2 前のステップが完了するまで、ステップ指示は使用できません。
2.
Program.cs 内の Main() で、Forest クラスの新しいインスタンスを作成し、その結果を変数 f に格納します。
*/

using System;

namespace DefiningClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
    }
  }
}
