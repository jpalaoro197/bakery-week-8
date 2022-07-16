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
      Console.WriteLine("would you like to add some water to your order of our super dry products? (y or n");
      string yesNoResponse = Console.ReadLine();
      if (yesNoResponse == "y")
      {
        Console.WriteLine("how many bottles would you like to add to your order");
        int waterResponse = int.Parse(Console.ReadLine());
        Bread userBread = new Bread(breadResponse);
        Pastry userPastry = new Pastry(pastryResponse);
        Water userWater = new Water(waterResponse);
        Console.WriteLine("For " + userBread.Quantity + " loafs of bread , " + userPastry.Quantity + " pastries and " + userWater.Quantity + " bottles of water. your total is $" + (userPastry.PastryCost() + userBread.BreadCost() + userWater.WaterCost()));
      }
      else if (yesNoResponse == "n")
      {
        Bread userBread = new Bread(breadResponse);
        Pastry userPastry = new Pastry(pastryResponse);
        Console.WriteLine("For " + userBread.Quantity + " loafs of bread and " + userPastry.Quantity + " pastries your total is $" + (userPastry.PastryCost() + userBread.BreadCost()));
      }
      else
      {
        Console.WriteLine("please answer 'y' or 'n' wether you want water or not.");
        string secondYesNo = Console.ReadLine();
        if (secondYesNo == "y")
        {
          Console.WriteLine("how many bottles would you like to add to your order");
        int waterResponse = int.Parse(Console.ReadLine());
        Bread userBread = new Bread(breadResponse);
        Pastry userPastry = new Pastry(pastryResponse);
        Water userWater = new Water(waterResponse);
        Console.WriteLine("For " + userBread.Quantity + " loafs of bread , " + userPastry.Quantity + " pastries and " + userWater.Quantity + " bottles of water. your total is $" + (userPastry.PastryCost() + userBread.BreadCost() + userWater.WaterCost()));
        }
        else if (secondYesNo == "n")
        {
          Bread userBread = new Bread(breadResponse);
          Pastry userPastry = new Pastry(pastryResponse);
          Console.WriteLine("For " + userBread.Quantity + " loafs of bread and " + userPastry.Quantity + " pastries your total is $" + (userPastry.PastryCost() + userBread.BreadCost()));
        }
        else
        {
          Console.WriteLine("please come back when you can make a simple decision, theres people waiting in line");
        }
      }
    }
  }
}