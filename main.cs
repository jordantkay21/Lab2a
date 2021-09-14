using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter the name of an item");
    string item=Console.ReadLine();

    Console.WriteLine ("Enter the quantity");
    int quantity=Convert.ToInt32 (Console.ReadLine());

    Console.WriteLine ("Enter the price");
    int price=Convert.ToInt32 (Console.ReadLine());


    int totalPrice= quantity*price;
    string message= "Total price of ";

    Console.WriteLine(message + item+"= "+ "$"+totalPrice);
    
  
  }
}