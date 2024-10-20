/*
Vehicle.cs で、LearnInheritance 名前空間内に空の Vehicle クラスを作成します。

文字列 LicensePlate プロパティ（ゲッターのみ） \
double Speed プロパティ（ゲッターおよびプライベート・セッター）
int Wheels プロパティ（ゲッターのみ）
void Honk() メソッド
SpeedUp() メソッド
SlowDown() メソッド
SpeedUp() および
SlowDown() は、それぞれ Speed から 5 を追加および削除する。
Honk() は、コンソールにメッセージ（HONK！など）を書き込む。
*/

using System;

namespace LearnInheritance
{
  class Vehicle
  {
    public string LicensePlate
    { get; }

    public double Speed
    { get; private set; }

    public int Wheels
    { get; }

    public void Honk()
    {
      System.Console.WriteLine("Honk!");
    }

    public void SpeedUp()
    {
      Speed += 5;
    }

    public void SlowDown()
    {
      Speed -= 5;
    }
  }
}

