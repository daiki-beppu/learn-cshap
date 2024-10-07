// この演習では、組み込みメソッドを使用して、2 つの異なる数値の平方根のうち、どちらの数値が小さいかを判断します。

// Starting variables
int numberOne = 12932;
int numberTwo = -2828472;

// Use built-in methods and save to variable
double numberOneSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberOne)));


// Use built-in methods and save to variable
double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));


// Print the lowest number

Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));


