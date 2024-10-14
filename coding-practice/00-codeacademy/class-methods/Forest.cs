/*
Forestクラスで、パブリック・メソッドGrow()を定義する。このメソッドは

引数をゼロにする。
木のプロパティを30、年齢のプロパティを1増やす。
更新された木の本数を返す。
チェックポイント2 ステップ命令は、前のステップが完了するまで使用できません。
2.
パブリック・メソッド Burn() を定義します。このメソッドは

引数をゼロにする。
treesフィールドを20減らし、ageプロパティを1増やす。
更新された木の本数を返す。
*/


using System;

namespace Methods
{
  public class Forest
  {
    public string name;
    public int trees;
    public int age;
    public string biome;


    public int Grow()
    {
      trees = 30;
      age += 1;

      return trees;
    }

    public int Burn()
    {
      trees -= 20;
      age += 1;

      return trees;
    }
  }
}

