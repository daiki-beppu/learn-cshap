/*
Sedan.csに戻る：SpeedとLicensePlateを設定するコンストラクタの行を削除します。
base(speed)を使用してスーパークラスのコンストラクタを呼び出します。
*/

using System;

namespace LearnInheritance
{
  class Sedan : Vehicle
  {
    public Sedan(double speed) : base(speed)
    {
      Wheels = 4;
    }
  }
}
