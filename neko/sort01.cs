using System;

class sort01
{
  public static void Main()
  {
    string [] name = new string[5]
      {
	"Eric", "Peter", "Frank", "Kate", "Thomas"
      };
    for (int i = 0; i < name.Length; i++)
      Console.WriteLine(name[i]);
    Console.WriteLine();

    Array.Sort(name);
    for (int i = 0; i < name.Length; i++)
      Console.WriteLine(name[i]);
    Console.WriteLine();

    Array.Reverse(name);
    for (int i = 0; i < name.Length; i++)
      Console.WriteLine(name[i]);

    int [] number = new int[5]
      {
	4, 5, 2, 1, 3
      };
    for (int i = 0; i < number.Length; i++)
      Console.WriteLine(number[i]);
    Console.WriteLine();

    Array.Sort(number);
    for (int i = 0; i < number.Length; i++)
      Console.WriteLine(number[i]);
    Console.WriteLine();

    Array.Reverse(number);
    for (int i = 0; i < number.Length; i++)
      Console.WriteLine(number[i]);

  }
}