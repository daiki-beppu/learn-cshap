// 配列の長さ


// 各プレイリストには8曲しか入れられないので、曲数が正しいかどうかをチェックするプログラムを書きたい。

// 8 曲あればコンソールに"summerStrut Playlist is raedy to go!"と出力
string[] summerStrut = new string[] {
  "Juice",
  "Missing U",
  "Raspberry Beret",
  "New York Groove",
  "Make Me Feel",
  "Rebel Rebel",
  "Despacito",
  "Los Angeles"
};

if (summerStrut.Length == 8 ) {
  System.Console.WriteLine( "summerStrut Playlist is ready to go!");
} else if (summerStrut.Length > 8) {
  System.Console.WriteLine("Too many songs!");
} else {
  System.Console.WriteLine("Add some songs!");
}
