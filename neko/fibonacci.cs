using System;

class fibo
{
  public long CalcFibo(int n)
  {
    long fb;

    if(n == 1 || n == 2)
      fb = 1;
    else
      {
	fb = CalcFibo(n - 1) + CalcFibo(n - 2);
      }
    return fb;
  }
}

class fibonacci
{
  public static void Main()
  {
    fibo f = new fibo();
    for (int i = 1; i <= 30; i++)
      {
	Console.WriteLine("f({0}) = {1}", i, f.CalcFibo(i));
      }
  }
}