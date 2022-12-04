using System;

class GroceryList
{
  static void Main()
  {
    string[] groceryList = { "eggs", "milk", "cheese", "ice cream" };
    int[] groceryListPrices = { 3, 4, 5, 6 };

    int counter = 1;
    Console.WriteLine("Grocery List:");
    foreach (string groceryItem in groceryList)
    {
      Console.WriteLine($"{counter}. {groceryItem}");
      counter++;
    }
    int total = 0;
    foreach (int itemPrice in groceryListPrices)
    {
      total += itemPrice;
    }
    Console.WriteLine($"Total Price: ${total}");
  }
}