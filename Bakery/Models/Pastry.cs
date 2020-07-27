namespace Bakery
{
  public class Pastry
  {
    public int Quantity { get; set; }
    public int PricePerPastry { get; }
    public string Name { get; }
    public int QuantityPrice { get; }
    public Pastry(int quantity)
    {
      Name = "Pastry";
      Quantity = quantity; 
      PricePerPastry = 2;
      QuantityPrice = this.PriceCalc();
    }
    public int PriceCalc() {
      return Quantity * PricePerPastry;
    }
    public int AddSalesPromo() 
    {
      int AdjustedPrice = 0;
      if (Quantity > 2) 
      {
      int Buy3Promo = (Quantity / 3) * 5;
      int Buy2Promo = (Quantity % 3) * 2; 
      AdjustedPrice = Buy3Promo + Buy2Promo;
      } 
      else if (Quantity <= 2)
      {
      int Buy2Promo = Quantity * 2; 
      AdjustedPrice = Buy2Promo; 
      }
      return AdjustedPrice;
    }
  }
}