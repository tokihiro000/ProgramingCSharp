using System;

class Kakeibo
{
  private int total = 0;
  
  public void nyukin(int en)
  {
    total += en;
    Console.WriteLine("{0}‰~‚ð“ü‹à‚µ‚Ü‚µ‚½", en);
    return;
  }

  public void shishutsu(int en)
  {
    if (total < en)
      {
	Console.WriteLine("{0}‰~‚àŽxo‚Å‚«‚Ü‚¹‚ñ", en);
	return;
      }
    else
      {
	total -= en;
	Console.WriteLine("{0}‰~‚ðŽxo‚µ‚Ü‚µ‚½", en);
	return;
      }
  }
  
  public void gettotal()
  {
    if (total == 0)
      {
	Console.WriteLine("Žc‚‚Í‚ ‚è‚Ü‚¹‚ñ");
	return;
      }
    else
      {
	Console.WriteLine("Žc‚‚Í{0}‰~‚Å‚·", total);
	return;
      }
  }
}

class noreturnvalue
{
  public static void Main()
  {
    Kakeibo k = new Kakeibo();
    k.gettotal();
    k.nyukin(1000);
    k.gettotal();
    k.nyukin(2000);
    k.gettotal();
    k.shishutsu(500);
    k.gettotal();
    k.shishutsu(10000);
    k.gettotal();
  }
}