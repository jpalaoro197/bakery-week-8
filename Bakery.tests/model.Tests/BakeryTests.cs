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
    public void  BreadCost_CostOneBreadNoDiscount_Int()
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
  }



}