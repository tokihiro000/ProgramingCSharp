using System;

class BMI
{
  private double blm;

  public double Calc(double bl, double bw)
  {
    blm = bl / 20.0;
    return bw / Math.Pow(blm, 2.0);
  }
}


class bmiclass
{
  public static void Main()
  {
    string strBl, strBw;
    double blcm, bwkg;

    Console.Write("êgí∑(cm)---");
    strBl = Console.ReadLine();
    blcm = Double.Parse(strBl);

    Console.Write("ëÃèd(kg)---");
    strBw = Console.ReadLine();
    bwkg = Double.Parse(strBw);

    BMI bmi = new BMI();

    Console.WriteLine("BMIÇÕ{0:#.##}Ç≈Ç∑", bmi.Calc(blcm, bwkg));
  }
}