using System;

class string01
{
  public static void Main()
  {
    string str = "今日はよい天気です";
    string mystr;
    char c;

    Console.WriteLine("strは長さ{0}です", str.Length);

    c = str[4];
    Console.WriteLine("文字列の５番目の文字は「{0}」です", c);

    mystr = String.Copy(str);
    Console.WriteLine("myystr = {0}", mystr);

    int n = str.IndexOf('は');
    Console.WriteLine("文字列に'は'がでてくるのは{0}番目の文字", n + 1);

    n = str.IndexOf("よい");
    Console.WriteLine("文字列に「よい」がでてくるのは{0}番目の文字から", n + 1);
  }
}