/*
次のツールとして、あなたは毎週のチームミーティングのテンプレートを作りたい。毎週新しいものを書き直すのではなく、一度に全部作ることにした。

16週にわたるプロジェクトで、各週に1回ずつ実行される空のforループを書きます。週には1から16までの番号を付けたいので、イテレータ変数は1から始め、ループは16以上になるまで実行し続けなければならない。

チェックポイント2 前のステップが完了するまで、ステップ命令は利用できない
2.
CreateTemplate 関数内の print 文を for ループ内に移動します。CreateTemplate関数は必要なくなりました。Console.WriteLine()の最初の呼び出しで、引数を更新して、反復変数の値を補間し、各週に正しい数字が表示されるようにします。
*/

for (int i = 1; i <= 16; i++)
{
  Console.WriteLine($"Week {i}");
  Console.WriteLine("Announcements: \n \n \n ");
  Console.WriteLine("Report Backs: \n \n \n");
  Console.WriteLine("Discussion Items: \n \n \n");
}
