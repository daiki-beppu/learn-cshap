/*
SpeedとLicensePlateを設定するコンストラクタの行を削除します。
base(speed)を使用してスーパークラスのコンストラクタを呼び出します。
*/

using System;

namespace LearnInheritance
{
  class Truck : Vehicle
  {
    public double Weight
    { get; }

    public Truck(double speed, double weight) : base(speed)
    {
      Weight = weight;

      if (weight < 400)
      {
        Wheels = 8;
      }
      else
      {
        Wheels = 12;
      }
    }

  }
}
