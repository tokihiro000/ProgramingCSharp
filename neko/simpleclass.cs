using System;

class myclass
{
  public int x;
}

class simpleclass
{
  public static void Main()
  {
    myclass mc = new myclass();
    mc.x = 10;
    Console.WriteLine("mc.x = {0}", mc.x);
  }
}