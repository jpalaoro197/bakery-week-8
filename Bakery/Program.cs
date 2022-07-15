using System;
using System.Collections.Generic;
using System.Linq;
using Bakery.Models;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Bakery");
      Console.WriteLine("A loaf of bread costs $" + Bread.Price);
      Console.WriteLine("Every third loaf of bread is free, so make sure you keep that in mind when you order!");
      Console.WriteLine("A pastry is $" + Pastry.Price);
      Console.WriteLine("If you buy two pastries then the third is 50% off");
      Console.WriteLine("How many loafs of bread would you like?");
      int breadResponse = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like?");
      int pastryResponse = int.Parse(Console.ReadLine());
      Bread userBread = new Bread(breadResponse);
      Pastry userPastry = new Pastry(pastryResponse);
      Console.WriteLine("For " + userBread.Quantity + " loafs of bread and " + userPastry.Quantity + " pastries your total is $" + (userPastry.PastryCost() + userBread.BreadCost())); 

    }
  }
}