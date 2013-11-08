using System;

class var01
{
  public static void Main()
  {
    var mytext = "猫でも分かるC#プログラミング 第";
    var no = 2;
    var myc = '版';

    Console.WriteLine(mytext + no + myc);
    Console.WriteLine("mytextの型は{0}で、noの型は{1}で、mycの型は{2}です",
		      mytext.GetType(), no.GetType(), myc.GetType());

    return;
  }
}