using System;

class escape01
{
  public static void Main()
  {
    char n= '\n';
    string str1 = "������";
    string str2 = "�ǂ��V�C�ł�";

    Console.WriteLine(str1 + n + str2);

    string str3 = "������\n�ǂ��V�C�ł�";
    Console.WriteLine(str3);
  }
}