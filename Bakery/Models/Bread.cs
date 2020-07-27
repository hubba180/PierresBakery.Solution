namespace Bakery
{
  public class Bread
  {
    public int Quantity { get; set; }
    public int PricePerPastry { get; }
    public string Name { get; }
    public int QuantityPrice { get; }
    public Bread(int quantity)
    {
      Name = "Bread";
      Quantity = quantity; 
      PricePerPastry = 5;
      QuantityPrice = this.PriceCalc();
    }

    public int PriceCalc() {
      return Quantity * PricePerPastry;
    }
    public int AddSalesPromo() 
    {
      int Remainder = (Quantity / 3) * 5;
      return QuantityPrice - Remainder;
    }
  }
}