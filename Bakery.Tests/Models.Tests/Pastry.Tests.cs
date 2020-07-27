using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry TestPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), TestPastry.GetType());
    }
    [TestMethod]
    public void PriceCalc_CalculatesPriceOfPastry_int()
    {
      Pastry TestPastry = new Pastry(2);
      int Answer = 4;
      Assert.AreEqual(Answer, TestPastry.PriceCalc());
    }
    [TestMethod]
    public void AddSalesPromo_AdjustQuantityPriceToIncludeDiscounts_Int()
    {
      Pastry TestPastry = new Pastry(6);
      Pastry TestPastry2 = new Pastry(2);
      Pastry TestPastry3 = new Pastry(7);
      int Answer1 = 10;
      int Answer2 = 4;
      int Answer3 = 12;
      Assert.AreEqual(Answer1, TestPastry.AddSalesPromo());
      Assert.AreEqual(Answer2, TestPastry2.AddSalesPromo());
      Assert.AreEqual(Answer3, TestPastry3.AddSalesPromo());
    }
  }
}