using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingListToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\...\samples\shoppingList";
            string fileName = @"\\myShoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myShoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add a new item to your shopping list? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your item:");
                    string userItem = Console.ReadLine();
                    myShoppingList.Add(userItem);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Have a good day!");
                }
            }

            Console.Clear();

            foreach (string item in myShoppingList)
            {
                Console.WriteLine($"Your item:{item}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myShoppingList);
        }
    }
}
