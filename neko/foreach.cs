using System;

class foreach01
{
  public static void Main()
  {
    string[] Animal = new string[]{ "Œ¢", "”L", "è³", "‰Ž" };
    int[] Num = new int[]{ 10, 20, 30, 40 };

    foreach (string str in Animal)
      {
       Console.WriteLine(str);
      }
    Console.WriteLine();
    foreach (int i in Num)
      {
       Console.WriteLine(i);
      }
  }
}