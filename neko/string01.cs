using System;

class string01
{
  public static void Main()
  {
    string str = "�����͂悢�V�C�ł�";
    string mystr;
    char c;

    Console.WriteLine("str�͒���{0}�ł�", str.Length);

    c = str[4];
    Console.WriteLine("������̂T�Ԗڂ̕����́u{0}�v�ł�", c);

    mystr = String.Copy(str);
    Console.WriteLine("myystr = {0}", mystr);

    int n = str.IndexOf('��');
    Console.WriteLine("�������'��'���łĂ���̂�{0}�Ԗڂ̕���", n + 1);

    n = str.IndexOf("�悢");
    Console.WriteLine("������Ɂu�悢�v���łĂ���̂�{0}�Ԗڂ̕�������", n + 1);
  }
}