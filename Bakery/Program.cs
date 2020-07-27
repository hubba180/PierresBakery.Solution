using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Program 
  {
    public static void Main(string[] args) 
    {
      List<Bread> BreadOrder = new List<Bread> {};
      List<Pastry> PastryOrder = new List<Pastry> {};
      bool OrderComplete = false;
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Press the enter key to begin an order!");
      Console.ReadLine();
      while (OrderComplete == false)
      {
        Console.Clear();
        Console.WriteLine("Please enter below whether you'd like to purchase a bread or pastry:");
        string OrderType = (Console.ReadLine()).ToLower();
        if (OrderType == "bread") 
        {
          Console.WriteLine("How much bread would you like add to your purchase? Please only enter a number.");
          string Quantity = Console.ReadLine();
          if (Int32.Parse(Quantity) >= 0)
          {
            Console.WriteLine("Great your order has been updated!");
          }
          else
          {
            Console.WriteLine("I'm sorry, you must enter a number");
            Quantity = Console.ReadLine();
          }
          Bread NewBreadOrder = new Bread(Int32.Parse(Quantity));
          BreadOrder.Add(NewBreadOrder);
          Console.WriteLine("Would you like to add another Item to your order? Reply 'yes' or 'no'.");
          string Answer = Console.ReadLine();
          if (Answer.ToLower() == "yes")
          {
            OrderComplete = false;
          }
          else if (Answer.ToLower() == "no")
          {
            OrderComplete = true;
          }
        } 
        else if (OrderType == "pastry") 
        {
          Console.WriteLine("How much Pastry would you like add to your purchase? Please only enter a number.");
          string Quantity = Console.ReadLine();
          if (Int32.Parse(Quantity) >= 0)
          {
            Console.WriteLine("Great your order has been updated!");
          }
          else
          {
            Console.WriteLine("I'm sorry, you must enter a number");
            Quantity = Console.ReadLine();
          }
          Pastry NewPastryOrder = new Pastry(Int32.Parse(Quantity));
          PastryOrder.Add(NewPastryOrder);
          Console.WriteLine("Would you like to add another Item to your order? Reply 'yes' or 'no'.");
          string Answer = Console.ReadLine();
          if (Answer.ToLower() == "yes")
          {
            OrderComplete = false;
          }
          else if (Answer.ToLower() == "no")
          {
            OrderComplete = true;
          }
        }
        else 
        {
          Console.WriteLine("I'm sorry we don't have that here, press the enter key to return to the previous question");
          Console.ReadLine();
        };
      };
      if (BreadOrder.Count > 0 && PastryOrder.Count > 0) 
      {
        int OrderTotal = 0;
        // BreadOrder[0].AddSalesPromo() + PastryOrder[0].AddSalesPromo();
        foreach (Bread item in BreadOrder)
        {
          OrderTotal += item.AddSalesPromo();
        }
        foreach (Pastry item in PastryOrder)
        {
          OrderTotal += item.AddSalesPromo();
        }
        Console.WriteLine($"Your order total is: ${OrderTotal}");
      } 
      else if (BreadOrder.Count > 0)
      {
        int OrderTotal = 0;
        // BreadOrder[0].AddSalesPromo();
        foreach (Bread item in BreadOrder)
        {
          OrderTotal += item.AddSalesPromo();
        }
        Console.WriteLine($"Your order total is: ${OrderTotal}");
      }
      else if (PastryOrder.Count > 0) 
      {
        int OrderTotal = 0;
        // PastryOrder[0].AddSalesPromo();
        foreach (Pastry item in PastryOrder)
        {
          OrderTotal += item.AddSalesPromo();
        }
        Console.WriteLine($"Your order total is: ${OrderTotal}");
      };
    }
  }
}