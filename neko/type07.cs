using System;

class type07
{
  public static void Main()
  {
    decimal total;

    Console.Write("借入金額---");
    decimal a = decimal.Parse(Console.ReadLine());
    Console.Write("利息(%)---");
    decimal p = decimal.Parse(Console.ReadLine());

    decimal r = p / 100M;

    total = a * (1m + r);

    Console.WriteLine("１期間あとの元利合計は{0:c}です", total);
    a = total;
    total = a * (1m + r);
    Console.WriteLine("２期間あとの元利合計は{0:c}です", total);
    a = total;
    total = a * (1m + r);
    Console.WriteLine("３期間あとの元利合計は{0:c}です", total);
    a = total;
    total = a * (1m + r);
    Console.WriteLine("４期間あとの元利合計は{0:c}です", total);

  }
}