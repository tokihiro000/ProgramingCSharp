using System;

class bool01
{
  public static void Main()
  {
    bool a = true;
    bool b = false;

    Console.WriteLine("a = {0}, b = {1}", a, b);
    Console.WriteLine("a��{0}", a.GetType());
    Console.WriteLine("a�͕�����ɂ���Ɓu{0}�v", a.ToString());
    Console.WriteLine("b�͕�����ɂ���Ɓu{0}�v", b.ToString());

  }
}