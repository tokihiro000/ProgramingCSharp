using System;

class type07
{
  public static void Main()
  {
    decimal total;

    Console.Write("Ø“ü‹àŠz---");
    decimal a = decimal.Parse(Console.ReadLine());
    Console.Write("—˜‘§(%)---");
    decimal p = decimal.Parse(Console.ReadLine());

    decimal r = p / 100M;

    total = a * (1m + r);

    Console.WriteLine("‚PŠúŠÔ‚ ‚Æ‚ÌŒ³—˜‡Œv‚Í{0:c}‚Å‚·", total);
    a = total;
    total = a * (1m + r);
    Console.WriteLine("‚QŠúŠÔ‚ ‚Æ‚ÌŒ³—˜‡Œv‚Í{0:c}‚Å‚·", total);
    a = total;
    total = a * (1m + r);
    Console.WriteLine("‚RŠúŠÔ‚ ‚Æ‚ÌŒ³—˜‡Œv‚Í{0:c}‚Å‚·", total);
    a = total;
    total = a * (1m + r);
    Console.WriteLine("‚SŠúŠÔ‚ ‚Æ‚ÌŒ³—˜‡Œv‚Í{0:c}‚Å‚·", total);

  }
}