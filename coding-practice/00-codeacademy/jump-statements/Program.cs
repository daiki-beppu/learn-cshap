﻿/*
あなたはポモドーロ・アプリケーションに戻ることに決めた。
今回は、アラームが延々と鳴り続けるのは避けたい。回鳴ったら、ボタンがクリックされていなくてもアラームを止めるようにします。

buttonClickの初期値を一時的にtrueに設定していることに注意してほしい。そうしないと、このコードをそのまま実行すると無限ループになってしまう！
buttonClickの初期値は、後のステップで更新します。

まず、アラームが何回鳴ったかを記録する変数を作成します。

チェックポイント2 ステップ命令は、前のステップが完了するまで使用できません。
2.
do...while ループの中で、アラームが鳴るたびにカウントを増やす。

チェックポイント3 前のステップが完了するまで、ステップ命令は使用できない。
3.
プログラムは、count 変数が 3 に達したらループを抜ける。

count 変数が 3 に達したかどうかをチェックするステートメントを書き、3 に達したら do...while ループから抜け出すようにします。

これで、buttonClickの開始値をfalseに更新して、アラームが3回鳴るのを確認できる。
*/

bool buttonClick = true;
int counter = 0;

do
{
  Console.WriteLine("BLARRRRR");
  counter ++;

  if (counter == 3) {
    buttonClick = false;
    break;
  };

} while (!buttonClick);