/*
ウェブサイトをブロックするアプリを作りたいので、ネットでコードを見つけ、テキストエディタにコピー＆ペーストする。
あなたは、このコードがウェブサイトの配列を繰り返し処理するためにwhileループを使っていることに気づきました！

もっと目的に合ったループを使うように、ループを書き直しなさい。
*/

string[] websites = { "twitter", "facebook", "gmail" };

foreach (string webService in websites)
{
  Console.WriteLine(webService);
}

// while (counter < websites.Length)
// {
//   Console.WriteLine(websites[counter]);
//   counter++;
// }
