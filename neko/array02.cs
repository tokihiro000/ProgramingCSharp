using System;

class array01
{
  public static void Main()
  {
    int[,] MyArray = {{1, 2, 3},{4, 5, 6}};		     
    
    for(int i = 0; i < 2; i++)
      {
	for(int j = 0; j < 3; j++)
	  {
	    Console.WriteLine("MyArra[{0}, {1}] = {2}", i, j, MyArray[i, j]);
	  }
      }

    }
}