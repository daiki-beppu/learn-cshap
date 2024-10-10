// 配列の編集

/*
プレイリストに新しい曲を追加しようと決めた。
しかし、おっと、8曲しか入れられません！
*/

string[] summerStrut;

summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

// プレイリストの最後の曲を、あなたが選んだ別の曲に入れ替えましょう。
summerStrut[7] = "song song song";
System.Console.WriteLine(summerStrut[7]);

// レーティングを変更してください。レーティングは1～3の整数であること
ratings[7] = 3;
System.Console.WriteLine(ratings[7]);
