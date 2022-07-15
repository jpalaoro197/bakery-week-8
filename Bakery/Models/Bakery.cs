using System;

namespace Bakery.Models
{
  public class Bread
  {
    private static double _Price = 5;
    //private double _Discount;
    public int Quantity { get; set; }

    public static double Price
    {
      get { return _Price; }
      set { _Price = value; }
    }

    public Bread(int quantity)
    {
      _Price = Price;
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
        else
        {
          breadTotal += _Price;
        }
      }
      return breadTotal;
    }
  }


}