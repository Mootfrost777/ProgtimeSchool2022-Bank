using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Model
{
    public class Transaction
    {
        private string category;
        private float price;
        
        public Transaction(string category, float price)
        {
            this.category = category;
            this.price = price;
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
