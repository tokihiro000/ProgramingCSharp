using System;

class var01
{
  public static void Main()
  {
    var mytext = "�L�ł�������C#�v���O���~���O ��";
    var no = 2;
    var myc = '��';

    Console.WriteLine(mytext + no + myc);
    Console.WriteLine("mytext�̌^��{0}�ŁAno�̌^��{1}�ŁAmyc�̌^��{2}�ł�",
		      mytext.GetType(), no.GetType(), myc.GetType());

    return;
  }
}