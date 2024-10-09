

int cookiesSoldGuess = 250;

// クッキーの販売数を初期化
int storeOneCookies = 110;
int storeTwoCookies = 135;

// クッキーの販売数の合計
int cookiesSoldActual = storeOneCookies + storeTwoCookies;

// 販売されたクッキーの合計数を正しく推測したかを表す
bool guessedCorrect = cookiesSoldGuess == cookiesSoldActual;

// 結果をコンソールに出力
System.Console.WriteLine(guessedCorrect);
