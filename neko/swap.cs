using System;

class myclass
{
  private int temp;

  public void swap(int x, int y)
  {
    temp = x;
    x = y;
    y = temp;
  }
}

class swap01
{
  public static void Main()
  {
    myclass s = new myclass();
    int x = 10, y = 20;
    s.swap(x, y);
    Console.WriteLine("x = {0}, y = {1}", x, y);
  }
}