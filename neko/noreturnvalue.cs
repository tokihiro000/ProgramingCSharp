using System;

class Kakeibo
{
  private int total = 0;
  
  public void nyukin(int en)
  {
    total += en;
    Console.WriteLine("{0}�~��������܂���", en);
    return;
  }

  public void shishutsu(int en)
  {
    if (total < en)
      {
	Console.WriteLine("{0}�~���x�o�ł��܂���", en);
	return;
      }
    else
      {
	total -= en;
	Console.WriteLine("{0}�~���x�o���܂���", en);
	return;
      }
  }
  
  public void gettotal()
  {
    if (total == 0)
      {
	Console.WriteLine("�c���͂���܂���");
	return;
      }
    else
      {
	Console.WriteLine("�c����{0}�~�ł�", total);
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