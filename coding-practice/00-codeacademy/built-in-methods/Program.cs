// 組み込みメソッド

/*
Arrayメソッドを使って、最初に3つ星に評価された曲の位置を求め、変数に保存する。

*/

string[] summerStrut;

summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

// コンソールに 「Song number X is rated three stars 」のようなメッセージを出力する。
System.Console.WriteLine($"Song number {Array.IndexOf(ratings, 3) + 1} is rated three stars");

// 配列メソッドを使用して summerStrut 内のタイトルの順序を逆にします。最初と最後のタイトルを出力
Array.Reverse(summerStrut);
System.Console.WriteLine(summerStrut[0]);
System.Console.WriteLine(summerStrut[summerStrut.Length - 1]);

// プレイリストをアルファベット順に整理、最初と最後の曲のタイトルをコンソールに出力
Array.Sort(summerStrut);
System.Console.WriteLine(summerStrut[0]);
System.Console.WriteLine(summerStrut[summerStrut.Length - 1]);
