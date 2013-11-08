using System;

class type09
{
  public static void Main()
  {
    char a = '\u732B';
    char b = '\x3067';
    char c = '‚à';
    char d = (char)12431;
    char e = '\u304B';
    char f = '\x308B';
    Console.WriteLine("{0}{1}{2}{3}{4}{5}", a, b, c, d, e, f);
  }
}