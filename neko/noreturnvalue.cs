using System;

class Kakeibo
{
  private int total = 0;
  
  public void nyukin(int en)
  {
    total += en;
    Console.WriteLine("{0}円を入金しました", en);
    return;
  }

  public void shishutsu(int en)
  {
    if (total < en)
      {
	Console.WriteLine("{0}円も支出できません", en);
	return;
      }
    else
      {
	total -= en;
	Console.WriteLine("{0}円を支出しました", en);
	return;
      }
  }
  
  public void gettotal()
  {
    if (total == 0)
      {
	Console.WriteLine("残高はありません");
	return;
      }
    else
      {
	Console.WriteLine("残高は{0}円です", total);
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