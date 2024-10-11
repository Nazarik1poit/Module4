using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal interface IProduct
    {
        string Name { get; }
        double Price { get; }
        int Stock { get; }

        double CalculateTotalValue();
        void AddToStock(int quantity);
        void RemoveFromStock(int quantity);

    }
}
