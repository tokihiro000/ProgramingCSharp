using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace num
{
    class Program
    {
    static void Main(String[] args)
    {
	int a = 12;
	int b, c;
	
	b = ++a;
	c = a++;
	Console.WriteLine("a = "+ a +", b = "+ b + ", c = "+c);
    }
    }
}