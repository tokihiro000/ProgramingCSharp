using System;

class isas01
{
  public static void Main()
  {
    object o;
    long l = 1;
    o = l;

    Console.WriteLine("o��long���{�b�N�X�����܂���");
    Console.WriteLine("o is long ---- {0}", o is long);
    Console.WriteLine("o is int  ---- {0}", o is int);




    Console.WriteLine();
    Console.WriteLine("���x��o�ɕ�����������܂���");
    o = "abc";
    Console.WriteLine("o is string ---- {0}", o is string);

  }
}