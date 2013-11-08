using System;

class array04
{
  public static void Main()
  {
    
    int[,,] ar = new int[2, 2, 3]{
      {
	{0, 1, 2},
	{3, 4, 5}
      },
      {
      {6, 7, 8},
      {9, 10, 11}
      }
    };
    
    Console.WriteLine("”z—ñ‚ÌŸŒ³ = {0}", ar.Rank);
    Console.WriteLine("ar‚ÌŒÂ”", ar.Length);
    for(int i = 0; i < 2; i++)
      for(int j = 0; j < 2; j++)
	for(int k = 0; k < 3; k++)
	  Console.Write("{0}", ar[i, j, k]);
    Console.WriteLine();
  }
}