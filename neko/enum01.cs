using System;

class enum01
{
  enum MyMonth
  {
    Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec
  };

  public static void Main()
  {
    Console.WriteLine("Apr‚Í{0}ŒŽ", (int)MyMonth.Apr);
    Console.WriteLine("May‚Í{0}ŒŽ", (int)MyMonth.May);
  }
}