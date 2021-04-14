using System;
using System.Collections.Generic;

namespace ShoppingListLabAO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Sweetness Paradise!");
            Console.WriteLine();
            bool runProgram = true;
            while (runProgram)
            {
                


                Dictionary<string, double> shop = new Dictionary<string, double>();
                shop.Add("grapefruit", 1.99);
                shop.Add("honeydew", 3.49);
                shop.Add("cauliflower", 1.59);
                shop.Add("drangonfruit", 2.19);
                shop.Add("Elderberry", 1.79);
                shop.Add("apple sauce", 0.99);
                shop.Add("banana pudding", 0.59);
                shop.Add("fig treats", 2.09);

                List<string> items = new List<string>();
                List<double> prices = new List<double>();

                Console.WriteLine("Item\t\tPrice");
                Console.WriteLine("=======\t\t=======");
                string choice;
                double result;
                foreach (KeyValuePair<string, double> kvp in shop)
                {
                    Console.WriteLine($"{kvp.Key}\t{kvp.Value}");
                }
                Console.WriteLine();
                Console.WriteLine("What item would you like to order? ");
                while (true)
                {
                    choice = Console.ReadLine();
                     
                    if (shop.TryGetValue(choice, out result))
                    {
                        items.Add(choice);
                        prices.Add(result);

                        Console.WriteLine(choice);
                        Console.WriteLine($"Adding {choice} to cart {result}");
                       
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, we don't have {choice}. Please try again");
                    }
                }
                Console.WriteLine("Would you like to order anything else? y/n");

                while (true)
                {
                    string loop = Console.ReadLine();
                    if (loop == "y")
                    {
                        break;
                    }
                    else if (loop == "n")
                    {
                        runProgram = false;
                        prices.Add(result);
                        Console.WriteLine("Thanks for you order!");
                        Console.WriteLine($"Here's what you got: ");
                        double sum = 0.0;
                        foreach (double i in prices)
                        {
                            Console.WriteLine(choice);
                            Console.WriteLine(result);
                            sum += result;
                        }
                        
                        Console.WriteLine();
                        double average = sum += result;
                        double averageT = average / result; 
                        Console.WriteLine($"Average price per item in order was {averageT}");
                        break;
                    }
                }



            }

        }
    }
}
