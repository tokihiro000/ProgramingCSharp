using System;

class object01
{
  public static void Main()
  {
    long l = 1;
    object o;
    int i;

    o = l;
    i = (int)o;
    Console.WriteLine(i);
  }
}