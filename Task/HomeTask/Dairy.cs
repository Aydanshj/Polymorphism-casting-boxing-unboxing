using System;
using System.Collections.Generic;
using System.Text;

namespace Hometask
{
    internal class Dairy : Product
    {

        public double FatPercent { get; set; }

        public void ShowDairyProducts()
        {
            Console.WriteLine($"No: {No} - Name: {Name} - Price: {Price} - FatPercent: {FatPercent}");
        }

    }
}
