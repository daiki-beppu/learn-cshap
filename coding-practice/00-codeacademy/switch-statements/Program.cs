// swithch 文

double ph = 4.5;

/* この if 文を switch 文で記述
if (ph < 7) {
  Console.WriteLine("Acidic");
} else if (ph > 7) {
  Console.WriteLine("Basic");
} else {
  Console.WriteLine("Neutral");
}
*/

/*
以下の要件を追加
- phが 3 以下の場合はを出力します"Very Acidic"。
- phが 11 以上の場合は、 を出力します"Very Basic"。
*/

switch (ph) {
  case <= 3:
    Console.WriteLine("Very Acidic");
    break;
  case < 7:
    Console.WriteLine("Acidic");
    break;
  case >= 11:
    Console.WriteLine("Very Basic");
    break;
  case > 7:
    Console.WriteLine("Basic");
    break;
  default:
    Console.WriteLine("Neutral");
    break;
}
