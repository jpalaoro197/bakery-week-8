using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void  BreadCost_CostOneBreadNoDiscount_Int()
    {
      //Arrange
      int breadQuantity = 1;
      double breadCost = 5;
      //Act
      Bread bakeryOrder = new Bread(breadQuantity);
      //Assert
      Assert.AreEqual(breadCost, bakeryOrder.BreadCost());
    }
    [TestMethod]
    public void  BreadCost_CostTwoBreadNoDiscount_Int()
    {
      //Arrange
      int breadQuantity = 2;
      double breadCost = 10;
      //Act
      Bread bakeryOrder = new Bread(breadQuantity);
      //Assert
      Assert.AreEqual(breadCost, bakeryOrder.BreadCost());
    }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void  PastryCost_CostOnePastryNoDiscount_Int()
    {
      //Arrange
      int pastryQuantity = 1;
      double pastryCost = 2;
      //Act
      Pastry bakeryOrder = new Pastry(pastryQuantity);
      //Assert
      Assert.AreEqual(pastryCost, bakeryOrder.PastryCost());
    }

    
    [TestMethod]
    public void  PastryCost_CostTwoPastryNoDiscount_Int()
    {
      //Arrange
      int pastryQuantity = 2;
      double pastryCost = 4;
      //Act
      Pastry bakeryOrder = new Pastry(pastryQuantity);
      //Assert
      Assert.AreEqual(pastryCost, bakeryOrder.PastryCost());
    }

    [TestMethod]
    public void  PastryCost_CostThreePastryDiscount_Int()
    {
      //Arrange
      int pastryQuantity = 3;
      double pastryCost = 5;
      //Act
      Pastry bakeryOrder = new Pastry(pastryQuantity);
      //Assert
      Assert.AreEqual(pastryCost, bakeryOrder.PastryCost());
    }

    [TestMethod]
    public void  PastryCost_CostSixPastryDiscount_Int()
    {
      //Arrange
      int pastryQuantity = 6;
      double pastryCost = 10;
      //Act
      Pastry bakeryOrder = new Pastry(pastryQuantity);
      //Assert
      Assert.AreEqual(pastryCost, bakeryOrder.PastryCost());
    }
  }



}