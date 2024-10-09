// 論理演算子

bool beach = true;
bool hiking = false;
bool city = true;

// bool 型で yourNeeds という名前の変数を作成し値は beach かつ city
bool yourNeeds = beach && city;

// bool 型で friendNeeds という名前の変数を作成し値は beach または haiking
bool friendNeeds = beach || hiking ;

// yourNeeds と friendNeeds を比較し tripDecision に保存
bool tripDecision = yourNeeds && friendNeeds;

// 結果をコンソールに出力
System.Console.WriteLine(tripDecision);
