using System;

class type07
{
  public static void Main()
  {
    decimal total;

    Console.Write("�ؓ����z---");
    decimal a = decimal.Parse(Console.ReadLine());
    Console.Write("����(%)---");
    decimal p = decimal.Parse(Console.ReadLine());

    decimal r = p / 100M;

    total = a * (1m + r);

    Console.WriteLine("�P���Ԃ��Ƃ̌������v��{0:c}�ł�", total);
    a = total;
    total = a * (1m + r);
    Console.WriteLine("�Q���Ԃ��Ƃ̌������v��{0:c}�ł�", total);
    a = total;
    total = a * (1m + r);
    Console.WriteLine("�R���Ԃ��Ƃ̌������v��{0:c}�ł�", total);
    a = total;
    total = a * (1m + r);
    Console.WriteLine("�S���Ԃ��Ƃ̌������v��{0:c}�ł�", total);

  }
}