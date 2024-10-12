/*
女子マラソンのトップタイムを分単位で保持するリストを作成する。double型の空のリストを作成し、変数marathonsに格納する。

チェックポイント2 ステップ指示は、前のステップが完了するまで使用できません。
2.
Jemima Sumgongは2016年のリオデジャネイロのマラソンで144.07分というタイムで優勝し、Tiki Gelanaは2012年のロンドンのマラソンで143.12分というタイムで優勝しています（これはちょうど2時間23分7.2秒です！）。

Add() ステートメントを2つ使って、これらの値をリストに追加します。

チェックポイント3 ステップ指示は、前のステップが完了するまで使用できません。
3.
リストの2番目の値をコンソールに表示する。
*/

using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<double> marathons = new List<double>();
      marathons.Add(144.07);
      marathons.Add(143.12);

      Console.WriteLine(marathons[1]);
    }
  }
}
