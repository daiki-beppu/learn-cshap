// else-if

/*
もしphが7より小さければ Acidic と表示する。
phが7より大きければ Basic と表示する。
そうでなければ Neutralと表示する。
*/

double ph = 3.0;

if (ph < 7)
{
  System.Console.WriteLine("Acidic");
}
else if (ph > 7)
{
  System.Console.WriteLine("Basic");
}
else
{
  System.Console.WriteLine("Neutral");
}
