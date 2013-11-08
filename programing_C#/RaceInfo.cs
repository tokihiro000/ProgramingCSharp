using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace RaceInfo
{
  class Program
  {
    static void Main(String []args)
    {
      double kmTravelled = double.Parse(args[0]);
      double elapsedSeconds = double.Parse(args[1]);
      double fuelKilosConsumed = double.Parse(args[2]);

      double fuelTankCapacityKilos = 80;
      double lapLength = 5.141;

      //1kmÇ†ÇΩÇËÇ…è¡îÔÇ≥ÇÍÇÈîRóøkg
      double fuelKilosPerKm = fuelKilosConsumed / kmTravelled;
      double 
    }
  }
}