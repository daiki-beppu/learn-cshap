/*
では、ToDoリストを作ってタスクを管理することにしよう。Todo配列の各項目を繰り返し処理する空のループを書きましょう。

チェックポイント2 前のステップが完了するまで、ステップの命令は使えない
2.
ループの中で、Console.WriteLine()を使って、現在のタスクを次のように表示する：
*/

string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };

foreach (string todoItem in todo)
{
  Console.WriteLine($"[] {todoItem}");
}
