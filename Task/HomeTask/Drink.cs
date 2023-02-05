using System;
using System.Collections.Generic;
using System.Text;

namespace Hometask
{
    internal class Drink : Product
    {

        public double AlcoholPercent { get; set; }

        public void ShowDrinkProducts()
        {
            Console.WriteLine($"No: {No}Name: {Name} - Price: {Price} - AlcoholPercent: {AlcoholPercent}");
        }

    }
}
