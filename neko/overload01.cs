using System;

class manymethods
{
  public int Method(int x)
  {
    Console.WriteLine("第１バージョンが呼ばれました");
    return x + 10;
  }
  public double Method(double x)
  {
    Console.WriteLine("第２バージョンが呼ばれました");
    return x * 2;
  }
  public string Method(string x)
  {
    Console.WriteLine("第３バージョンが呼ばれました");
    return x += "です";
  }
  public int Method(int x, int y)
  {
    Console.WriteLine("第４バージョンが呼ばれました");
    return x + y;
  }
}

class overload01
{
  public static void Main()
  {
    manymethods m = new manymethods();
    Console.WriteLine("その戻り値は「{0}」です", m.Method(3));
    Console.WriteLine("その戻り値は「{0}」です", m.Method(3.2));
    Console.WriteLine("その戻り値は「{0}」です", m.Method("古井"));
    Console.WriteLine("その戻り値は「{0}」です", m.Method(5, 6));
  }
}