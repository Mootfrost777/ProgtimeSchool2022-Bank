using System.ComponentModel;
using Newtonsoft.Json;

namespace MauiApp1.Model
{
    public class Transaction : INotifyPropertyChanged
    {
        private string category;
        private float price;
        private DateTime date;

        [JsonConstructor]
        public Transaction(string category, float price)
        {
            this.category = category;
            this.price = price;
            date = DateTime.Now;
        }
        
        [JsonProperty]
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        [JsonProperty]
        public string Category
        {
            get { return category; }
            set
            {
                if (value != category)
                {
                    category = value;
                    OnPropertyChanged(nameof(Category));
                }
            }
        }

        [JsonProperty]
        public float Price
        {
            get { return price; }
            set
            {
                if (value != price)
                {
                    price = value;
                    OnPropertyChanged(nameof(Price));
                }
            }
        }
    
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            if (property != null)
            {
                PropertyChanged(this, new(property));
            }
        }
    }
}
