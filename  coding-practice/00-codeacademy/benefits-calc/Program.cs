// 複利計算のプログラム

decimal capital = 1_000_000m;
decimal interest = 0.04m;

for (int i = 1; i <= 10; i++)
{
  System.Console.WriteLine($"{i}年目:元本{capital:C}");
  System.Console.WriteLine($"{i}年目:利息{interest}");
  capital += capital * interest;
  System.Console.WriteLine($"{i}年目:元本+利息{capital:C}");
  System.Console.WriteLine("-----------------------------");
}
