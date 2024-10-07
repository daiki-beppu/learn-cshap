
// dna strand
string startStrand = "ATGCGATGAGCTTAC";

// "TGAの位置を見つける"
int tga = startStrand.IndexOf("TGA");


int startPoint = 0;
int length = tga + 3; // "T"がある場所から3文字先のインデックス

// startPointから始まって長さがlengthの部分文字列を取得
string dna = startStrand.Substring(startPoint, length);
System.Console.WriteLine(dna);

System.Console.WriteLine(dna[3]);
