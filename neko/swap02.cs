using System;

class myclass
{
  private string temp;

  public void swap(string str1, string str2)
  {
    temp = str1;
    str1 = str2;
    str2 = temp;
    Console.WriteLine("swap:str1 = {0}, str2 = {1}", str1, str2);
  }
}

class swap02
{
  public static void Main()
  {
    string str1 = "犬", str2 = "猫";
    myclass s = new myclass();
    s.swap(str1, str2);
    Console.WriteLine("Main:str1 = {0}, str2 = {1}", str1, str2);
  }
}