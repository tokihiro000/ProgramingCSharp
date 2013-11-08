using System;

class contine01
{
  public static void Main()
  {
    int sum = 0;

    for(int i = 0; i < 100; i++){
      if(i % 2 == 0)
	{
	    sum += i;
	}
      else
	{
	  continue;	  
	}
	
	Console.WriteLine("i = {0, 2}, sum = {1, 4}", i, sum);
      }
    Console.WriteLine("‡Œv‚Í{0}‚Å‚·", sum);
  }
}