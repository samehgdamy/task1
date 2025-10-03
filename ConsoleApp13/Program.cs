using System;

class Program
{
    static void Main()
    {
        int priceSmall = 25;
        int priceLarge = 35;
        double taxRate = 0.06;

        
        Console.WriteLine("Welcome to Carpet Cleaning Service");
        Console.WriteLine("Each small carpet costs: $" + priceSmall);
        Console.WriteLine("Each large carpet costs: $" + priceLarge);
        Console.WriteLine("Tax rate: " + (taxRate * 100) + "%");
        Console.WriteLine("----------------------------------");

        
        Console.Write("Enter number of small carpets: ");
        int small = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of large carpets: ");
        int large = Convert.ToInt32(Console.ReadLine());

        
        int cost = (small * priceSmall) + (large * priceLarge);
        double tax = cost * taxRate;
        double total = cost + tax;

       
        Console.WriteLine("\nEstimate for carpet cleaning service");
        Console.WriteLine("Number of small carpets: " + small);
        Console.WriteLine("Number of large carpets: " + large);
        Console.WriteLine("Cost: $" + cost);
        Console.WriteLine("Tax: $" + tax.ToString("0.00"));
        Console.WriteLine("Total estimate: $" + total.ToString("0.00"));
        Console.WriteLine("This estimate is valid for 30 days");
    }
}