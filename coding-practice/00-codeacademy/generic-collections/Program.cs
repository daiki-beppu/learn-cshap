/*
1.
System.Collections.Genericネームスペースへの参照を追加します。

チェックポイント2 前のステップが完了するまで、ステップ指示は利用できない
2.
3つの空のリストを宣言する：

1つはbool型
1つはRandom型を保持する
1つはIServiceProvider型を保持する
その通り、ここでもインターフェイスは機能する！
*/

using System;
using System.Collections.Generic;
namespace LearnLists

{
  class Program
  {
    static void Main()
    {
      List<bool> list1 = new List<bool>();
      List<Random> list2 = new List<Random>();
      List<IServiceProvider> list3 = new List<IServiceProvider>();
    }
  }
}
