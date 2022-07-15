using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Cafe");
      Console.WriteLine("A loaf of bread costs $" + Bread.Price);
      Console.WriteLine("Every third loaf of bread is free, so make sure you keep that in mind when you order!");
      Console.WriteLine("A pastry is $" + Pastry.Price);
      Console.WriteLine("If you buy two pastries then the third is 50% off");
    }
  }
}