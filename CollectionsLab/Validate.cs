using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CollectionsLab
{
    class Validate
    {
        //public static ArrayList Quantity = new ArrayList();

        public static Fruit TestEnumParse (string temp)
        {
            while (true)
            {
                Fruit ToReturn;
                if (Enum.TryParse(temp, out ToReturn) == true)
                {
                    return ToReturn;
                }
                else
                {
                    Console.WriteLine("Sorry, we don't have that. Try again");
                    temp = Console.ReadLine();
                }
            }
        }

        public static void ItemCheck(Fruit item)
        {
            while (true)
            {
                double price;
                if (Program.ItemPrice.TryGetValue(item, out price) == true)
                {
                    Program.CartItems.Add(item);
                    Program.CartPrice.Add(price);
                    Console.WriteLine("Would you like to add another item? (y/n)");
                    if (AddMoreItems(Console.ReadLine().ToLower()) == true)
                    {
                        Console.Clear();
                        item = Program.PrintMenu();
                    }
                    else
                        break;
                }
                else
                {
                    Console.WriteLine("Sorry, we don't have those. Try again");
                    item = (Fruit)Enum.Parse(typeof(Fruit), Console.ReadLine().ToLower());
                }
            }
        }

        public static bool AddMoreItems(string x)
        {
            while (true)
            {
                if (Regex.IsMatch(x, "^(yes|y)$"))
                    return true;
                else if (Regex.IsMatch(x, "^(no|n)$"))
                    return false;
                else
                {
                    Console.WriteLine("Invalid input. Try again!");
                    x = Console.ReadLine().ToLower();
                }
            }
        }
        
        public static bool Continue()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to start another order? (y/n)");
            string x = Console.ReadLine().ToLower();

            while (true)
            {
                if (Regex.IsMatch(x, "^(yes|y)$"))
                {
                    Program.CartItems.Clear();
                    Program.CartPrice.Clear();
                    return true;
                }
                else if (Regex.IsMatch(x, "^(no|n)$"))
                    return false;
                else
                {
                    Console.WriteLine("Invalid input. Try again!");
                    x = Console.ReadLine().ToLower();
                }
            }
        }
    }
}
