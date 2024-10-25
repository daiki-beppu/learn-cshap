/*
TruckをVehicleから継承させる: コロン構文を使用して、TruckがVehicleクラスから継承していることを知らせます。 Truckから重複するプロパティとメソッドを削除します。
*/

using System;

namespace LearnInheritance
{
  class Truck : Vehicle
  {
    public double Weight
    { get; }

    public Truck(double speed, double weight)
    {
      Speed = speed;
      LicensePlate = Tools.GenerateLicensePlate();
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
