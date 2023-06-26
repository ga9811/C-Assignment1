using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruits_System
{
    internal class Fruits
    {
        int productId;
        string productName;
        decimal amount;
        decimal price;
        decimal weight;

        public Fruits(int productId, string productName, decimal amount, decimal price)
        {
            this.productId = productId;
            this.productName = productName;
            this.amount = amount;
            this.price = price;
        }

        public Fruits()
        {
        }

        public Fruits(int productId, decimal weight, decimal price)
        {
            this.productId = productId;
            
            this.weight = weight;
            this.price = price;
        }
        public decimal ItemSale(decimal weight, decimal price)
        {
            decimal itemSale = weight * price;
            return itemSale;
        }

        private static decimal totalSale = 0;

        public static void AddToTotalSale(decimal itemSale)
        {
            totalSale += itemSale;
        }

        public static decimal GetTotalSale()
        {
            return totalSale;
        }

    }
}
