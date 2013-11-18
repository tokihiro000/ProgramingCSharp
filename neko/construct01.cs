using System;

class MyClass
{
  int x;

  public void showx()
  {
    Console.WriteLine("x = " + x);
  }

  public MyClass()
  {
    x = 10;
    Console.WriteLine("xに10を代入しました");
  }
}

class construct01
{
  public static void Main()
  {
    MyClass mc = new MyClass();
    mc.showx();
  }
}