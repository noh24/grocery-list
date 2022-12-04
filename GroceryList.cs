using System;

// class GroceryList
// {
//   static void Main()
//   {
//     string[] groceryList = { "eggs", "milk", "cheese", "ice cream" };
//     int[] groceryListPrices = { 3, 4, 5, 6 };

//     int counter = 1;
//     Console.WriteLine("Grocery List:");
//     foreach (string groceryItem in groceryList)
//     {
//       Console.WriteLine($"{counter}. {groceryItem}");
//       counter++;
//     }
//     int total = 0;
//     foreach (int itemPrice in groceryListPrices)
//     {
//       total += itemPrice;
//     }
//     Console.WriteLine($"Total Price: ${total}");
//   }
// }

class LeapYear
{
  static void Main()
  {
    Console.WriteLine("Enter your birth year");
    string stringBirthYear = Console.ReadLine();
    int birthYear = int.Parse(stringBirthYear);
    Console.WriteLine("These are all the leap years you've lived through:");
    int counter = 0;
    for (int year = birthYear; year <= 2022; year++)
    {
      if (year % 4 == 0)
      {
        Console.WriteLine(year);
        counter++;
      }
    }
    Console.WriteLine($"You have lived through {counter} leap years.");
    // leap years that occured since birth
  }
}