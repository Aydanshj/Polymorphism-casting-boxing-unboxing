using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrinkProduct drink1 = new DrinkProduct
            {
                AlcoholPercent = 1,
                Name = "Coca Cola 1L",
                Price = 4
            };
            DrinkProduct drink2 = new DrinkProduct
            {
                AlcoholPercent = 2,
                Name = "Pepsi Cola 1L",
                Price = 5
            };

            DairyProduct dairy1 = new DairyProduct
            {
                FatPercent = 9,
                Name = "Atena ayran 1L",
                Price = 3
            };
            DairyProduct dairy2 = new DairyProduct
            {
                FatPercent = 20,
                Name = "Milla ayran 1L",
                Price = 2
            };
            DairyProduct dairy3 = new DairyProduct
            {
                FatPercent = 0,
                Name = "Azersud ayran 1L",
                Price = 1
            };

            Product[] products = { drink1, drink2, dairy1, dairy2, dairy3 };

            int count = 0;
            double sum = 0;
            foreach (var item in products)
            {
                if (item is DairyProduct)
                {
                    DairyProduct dp = item as DairyProduct;
                    sum += dp.FatPercent;

                    count++;
                }
            }

            Console.WriteLine(count);
            Console.WriteLine(sum);
            Console.WriteLine(sum / count);

        }
    }
    
}
