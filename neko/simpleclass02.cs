using System;

class MyClass
{
  public int x;
}

class simpleclass02
{

  public static void Main()
  {
    MyClass a, b;
    a = new MyClass();
    b = new MyClass();

    a.x = 10;
    b.x = 10;

    Console.WriteLine("a.x = {0}, b.x = {1}", a.x, b.x);
  }
}