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
  }



}