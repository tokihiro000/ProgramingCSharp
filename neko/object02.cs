using System;

class object01
{
  public static void Main()
  {
    object o;
    int i, a = 100;

    o = a;
    i = (int)o;
    Console.WriteLine("i = {0}", o);
  }
}