using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread TestBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), TestBread.GetType());
    }

    [TestMethod]
    public void PriceCalc_CalculatesPriceOfBread_Int()
    {
      Bread TestBread = new Bread(2);
      int Answer = 10;
      Assert.AreEqual(Answer, TestBread.PriceCalc());
    }
    [TestMethod]
    public void AddSalesPromo_AdjustQuantityPriceToIncludeDiscounts_Int()
    {
      Bread TestBread = new Bread(6);
      int Answer = 20;
      Assert.AreEqual(Answer, TestBread.AddSalesPromo());
    }
  }
}