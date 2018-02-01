﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CollectionsLab
{
    public enum Fruit { watermelon = 1, apple, clementine, dragonfruit, banana, bellpepper, pomegranate, coconut };

    class Program
    {
        public static ArrayList CartItems = new ArrayList();
        public static ArrayList CartPrice = new ArrayList();
        public static Dictionary<Fruit, double> ItemPrice = new Dictionary<Fruit, double>();

        static void Main(string[] args)
        {
            AddToMenu();

            while (true)
            {
                Validate.ItemCheck(PrintMenu());

                Calculate.AverageCost();
                Calculate.LowestCost();
                Calculate.HighestCost();
                if (Validate.Continue() == false)
                    break;
            }

        }

        private static void AddToMenu()
        {
            ItemPrice.Add(Fruit.watermelon, 3.99);
            ItemPrice.Add(Fruit.apple, 0.99);
            ItemPrice.Add(Fruit.clementine, 0.99);
            ItemPrice.Add(Fruit.dragonfruit, 2.19);
            ItemPrice.Add(Fruit.banana, 0.59);
            ItemPrice.Add(Fruit.bellpepper, 0.69);
            ItemPrice.Add(Fruit.pomegranate, 2.99);
            ItemPrice.Add(Fruit.coconut, 4.99);
        }

        public static Fruit PrintMenu()
        {
            Console.WriteLine("Item\t\t\tPrice");
            Console.WriteLine(new string('=', 30));
            int FruitIndex = 1;
            foreach (KeyValuePair<Fruit, double> entry in ItemPrice)
            {
                string ToPrint = string.Format("{0}: {1}\t\t{2:0.00}", FruitIndex, entry.Key, entry.Value);
                Console.WriteLine(ToPrint);
                FruitIndex++;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Enter the number of what you want to order: ");
            string ToReturn = Console.ReadLine();
            return Validate.TestEnumParse(ToReturn);
        }

        public static void PrintCart()
        {
            Console.Clear();
            Console.WriteLine(new string('*', 30));
            Console.WriteLine("Item\t\t\tPrice");
            Console.WriteLine(new string('=', 30));

            int z = 0;
            foreach (Fruit i in CartItems)
            {
                string ToPrint = string.Format("{0}: {1}\t\t{2:0.00}", (z+1), i, CartPrice[z]);

                Console.WriteLine(ToPrint);
                z++;
            }
            Console.WriteLine(new string('*', 30));
        }
    }
}