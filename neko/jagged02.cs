using System;

class jagged02
{
  public static void Main()
  {
    string[][] name = new string[2][];
    name[0] = new string[2]
      {
	"�c��", "�H��"
      };
    name[1] = new string[3]
      {
	"�g�c", "����", "�r�c"
      };

    for(int i = 0; i < name[0].Length; i++)
      Console.WriteLine(name[0][i]);
    for(int i = 0; i < name[1].Length; i++)
      Console.WriteLine(name[1][i]);
  }
}