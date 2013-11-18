using System;

class DestructTest
{
  int x;

  ~DestructTest()
  {
    Console.WriteLine("デストラクタが呼ばれました");
    Console.WriteLine("xは{0}です", x);
  }

  public DestructTest(int n)
  {
    Console.WriteLine("コンストラクタが呼ばれました");
    x = n;
    Console.WriteLine("xに{0}を代入しました", n);
  }
}

class destruct
{
  public static void Main()
  {
    DestructTest dt1 = new DestructTest(1);
    Console.WriteLine("dt1生成");
    DestructTest dt2 = new DestructTest(2);
    Console.WriteLine("dt2生成");
    DestructTest dt3 = new DestructTest(3);
    Console.WriteLine("dt3生成");
  }
}