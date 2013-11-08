using System;
using System.Collections;
using System.Linq;
using System.Text;

class Program
{
    static void Main(String []args)
    {
	double a = Square(5.0);
	Console.WriteLine(a);
    }
    static double Square(double x)
    {
	return x*x;
    }
}
