/*
Sedan.csでは、コロン構文を使用して、SedanがVehicleクラスを継承することを宣言します。

コンソールにCS0108の警告がたくさん表示されていませんか？
SedanはVehicleのメンバを継承しているので、それらのメンバを再定義してはいけません！
Sedan.csから継承したメンバをすべて削除してください。
Sedanが許可されていないメンバにアクセスしているというエラーが表示されますが、大丈夫です！ 次の練習で修正します。
*/

using System;

namespace LearnInheritance
{
  class Sedan : Vehicle
  {
    public Sedan(double speed)
    {
      Speed = speed;
      LicensePlate = Tools.GenerateLicensePlate();
      Wheels = 4;
    }
  }
}
