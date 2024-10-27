/*
現在、セダンのコンストラクタはVehicleのデフォルトのパラメータレスコンストラクタ（Vehicle()として知られています）を暗黙的に呼び出しています。
Vehicleのコンストラクタを明示的に定義してみましょう。
これは、SedanとTruckのコンストラクタと非常に似ていることに注意してください。 これを実行すると、次のようなエラーが表示されます。
error CS7036: 'Vehicle.Vehicle(double)'の正式パラメータ'speed'に対応する引数がありません！
これは、SedanコンストラクタがパラメータなしのコンストラクタVehicle()を呼び出していることを証明しています。
コンストラクタVehicle(double speed)を明示的に定義したため、Vehicle()は存在しなくなり、エラーとなった。

Vehicleで定義されたLicensePlateとSpeedプロパティは、SedanやTruckではアクセスされなくなったため、保護する必要がなくなりました。
これら2つのセッターをprivateに切り替えてください。
*/

using System;

namespace LearnInheritance
{
  class Vehicle
  {
    public Vehicle(double speed)
    {

    }
    public string LicensePlate
    { get; private set; }

    public double Speed
    { get; private set; }

    public int Wheels
    { get; protected set; }

    public void SpeedUp()
    {
      Speed += 5;
    }

    public void SlowDown()
    {
      Speed -= 5;
    }

    public void Honk()
    {
      Console.WriteLine("HONK!");
    }

  }
}
