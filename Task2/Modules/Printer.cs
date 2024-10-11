using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Task2.Modules
{
    internal class Printer: IProduct
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public int Stock { get; private set; }

        public Printer(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public double CalculateTotalValue()
        {
            return Stock * Price;
        }

        public void AddToStock(int quantity)
        {
            Stock += quantity;
        }

        public void RemoveFromStock(int quantity)
        {
            if (Stock >= quantity)
            {
                Stock -= quantity;
            }
            else
            {
                MessageBox.Show("Недостаточно товара на складе");
            }
        }
    }
}
