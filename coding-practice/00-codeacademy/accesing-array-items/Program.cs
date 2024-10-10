// 配列内のデータにアクセスする

/*
プレイリストの2番目の曲名と、あなたがつけた評価を含むステートメントをプリントアウトしてください
メッセージには 「You rated the song Missing U 4 stars. 」のように書いてください。
*/

string[] summerStrut;

summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

System.Console.WriteLine($"You rated the song {summerStrut[1]} {ratings[1]} stars");
