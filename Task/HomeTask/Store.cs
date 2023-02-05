using System;
using System.Collections.Generic;
using System.Text;

namespace Hometask
{
    internal class Store
    {

        private Product[] _products = new Product[0];

        private double DairyProductCountLimit;

        private double AlcoholPercentLimit;


        public void AddProduct(Product product)
        {
            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length - 1] = product;
        }

        public bool HasProductByNo(int no)
        {
            foreach (var item in _products)
            {
                if (item.No == no)
                    return true;
            }

            return false;
        }

        public Product GetProductByNo(int no)
        {

            foreach (var item in _products)
            {
                if (item.No == no)
                    return item;
            }

            throw new Exception();
        }

        public Dairy[] GetDairyProducts(Dairy[] _product)
        {
            Dairy[] dairies = new Dairy[0];
            foreach (var item in _products)
            {
                if (item is Dairy)
                {
                    Array.Resize(ref dairies, dairies.Length + 1);
                    dairies[dairies.Length - 1] = item as Dairy;
                }
            }
            return dairies;
        }

        public Drink[] GetDrinkProducts(Drink[] _products)
        {
            Drink[] drinks = new Drink[0];
            foreach (var item in _products)
            {
                if (item is Drink)
                {
                    Array.Resize(ref drinks, drinks.Length + 1);
                    drinks[drinks.Length - 1] = item as Drink;
                }
            }
            return drinks;

        }

    }
}
