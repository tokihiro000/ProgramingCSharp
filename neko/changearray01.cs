using System;

class change
{
  public void modify(int[] array)
  {
    int n = array.Length;
    for(int i = 0; i < n; i++)
      {
	array[i] *= 2;
      }
  }
}

class changearray01
{
  public static void Main()
  {
    change c = new change();
    int [] myarray = new int[3]{1, 2, 3};

    Console.WriteLine("---- 　modifyメソッド実行前  ----");
    int i = 0;
    foreach(int x in myarray)
      {
	Console.WriteLine("myarray[{0}] = {1}", i, x);
	i++;
      }

    c.modify(myarray);

    Console.WriteLine("---- 　modifyメソッド実行前  ----");
    i = 0;
    foreach(int x in myarray)
      {
	Console.WriteLine("myarray[{0}] = {1}", i, x);
	i++;
      }
  }
}