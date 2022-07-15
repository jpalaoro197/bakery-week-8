using System;

namespace Bakery.Models
{
  public class Bread
  {
    private static double _Price = 5;
    private double _Discount;
    public int Quantity { get; set; }

    public static double Price
    {
      get { return _Price; }
      set { _Price = value; }
    }

    public Bread(int quantity)
    {
      _Price = Price;
      _Discount = 0;
      Quantity = quantity;
    }

    public double BreadCost()
    {
      double breadTotal = 0;
      for (int index = 0; index <= Quantity; index++)
      {
        if (index == 0)
        {
          breadTotal += 0;
        } 
        else if (index % 3 == 0) 
        {
          breadTotal += _Price * _Discount;
        }
        else
        {
          breadTotal += _Price;
        }
      }
      return breadTotal;
    }
  }

  public class Pastry
  {
    private static double _Price = 2;
    private double _Discount;
    public int Quantity { get; set; }

    public static double Price
    {
      get { return _Price; }
      set { _Price = value; }
    }

    public Pastry(int quantity)
    {
      _Price = Price;
      _Discount = 0.5;
      Quantity = quantity;
    }

    public double PastryCost()
    {
      double pastryTotal = 0;
      for (int index = 0; index <= Quantity; index++)
      {
        if (index == 0)
        {
          pastryTotal += 0;
        } 
        else if (index % 3 == 0) 
        {
          pastryTotal += _Price * _Discount;
        }
        else
        {
          pastryTotal += _Price;
        }
      }
      return pastryTotal;
    }
  }

  public class Water
  {
    private static double _Price = 4;
    public int Quantity { get; set; }

    public static double Price
    {
      get { return _Price; }
      set { _Price = value; }
    }

    public Water(int quantity)
    {
      _Price = Price;
      Quantity = quantity;
    }

    public double WaterCost()
    {
      double waterTotal = 0;
      for (int index = 0; index <= Quantity; index++)
      {
        if (index == 0)
        {
          waterTotal += 0;
        } 
        else
        {
          waterTotal += _Price;
        }
      }
      return waterTotal;
    }
  }
}