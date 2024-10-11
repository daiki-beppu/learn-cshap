// 比較演算子

internal class Program
{
  private static void Main(string[] args)
  {
    // 変数を作成し午後2時から午後6時までの時間差を格納
    double timeToDinner = 4;

    // double型でdistanceという名前の変数を作成、値は 95
    // double型でrateという名前の変数を作成、値は 30

    double distance = 95;
    double rate = 30;

    // 所要時間を計算
    double tripDuration = distance / rate;

    // 時間差と所要時間を比較
    bool answer = tripDuration <= timeToDinner;

    // 結果をコンソールに出力
    Console.WriteLine(answer);
  }
}
