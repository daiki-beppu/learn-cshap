// Script line
string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";

// Get camera directions
int charPosition = script.IndexOf("Close");
int length = "Close on".Length;
string cameraDirections = script.Substring(charPosition, length);

// Get scene description
charPosition = script.IndexOf("a portrait");
string sceneDescription = script.Substring(charPosition);

// cameraDirections大文字にして、変数に再保存
cameraDirections = cameraDirections.ToUpper();

// sceneDescription小文字にして変数に再保存
sceneDescription = sceneDescription.ToLower();

// 結果をコンソールに出力
System.Console.WriteLine(cameraDirections);
System.Console.WriteLine(sceneDescription);
