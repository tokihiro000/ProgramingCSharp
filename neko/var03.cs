using System;

class var03
{
  public static void Main()
  {
    var name = new [] {"���Y", "���Y", "�O�Y", "�l�Y" };

    for (var i = 0; i< name.Length; i++)
      Console.WriteLine(name[i]);

    var f = new [] { 0.5, 0.9, 1.5, 2.3 };
    for (var i = 0; i < f.Length; i++)
      Console.WriteLine(f[i]);

    Console.WriteLine("name�̌^��{0}, f�̌^��{1}", name.GetType(), f.GetType());

  }
}