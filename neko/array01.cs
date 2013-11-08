using System;

class array01
{
  public static void Main()
  {
    int[,] MyArray = new int[2,3];
    int i, j;

    MyArray[0, 0] = 1;
    MyArray[0, 1] = 2;
    MyArray[0, 2] = 3;
    MyArray[1, 0] = 4;
    MyArray[1, 1] = 5;
    MyArray[1, 2] = 6;

    for(i = 0; i < 2; i++)
      {
	for(j = 0; j < 3; j++)
	  {
	    Console.WriteLine("MyArra[{0}, {1}] = {2}", i, j, MyArray[i, j]);
	  }
      }
  }
}