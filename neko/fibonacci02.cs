using System;

class fibo02
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

class fibonacci02
{
  public static void Main()
  {
    fibo02 f = new fibo02();

    for(int i = 1; i <= 10; i++)
      {
	Console.WriteLine("n = {0, 2}, f(2 * {0, 2}) = {1, 4}, f({0, 2}) = {2, 3}, {1, 4} / {2, 3}の余り...{3}", i, f.CalcFibo(i * 2), f.CalcFibo(i), f.CalcFibo(i * 2) % f.CalcFibo(i));
      }
  }
}