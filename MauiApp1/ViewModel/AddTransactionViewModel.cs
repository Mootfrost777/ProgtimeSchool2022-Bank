using System.Collections.ObjectModel;
using System.Windows.Input;
using MauiApp1.Model;
using MauiApp1.Helpers;

namespace MauiApp1.ViewModel
{
    public class AddTransactionViewModel
    {
        public string CategoryEntry { get; set; }
        public float PriceEntry { get; set; }

        public ICommand AddTransactionCommand { get; set; }
        private ObservableCollection<Transaction> transactions;
        private Transaction transaction;
        
        public AddTransactionViewModel(ObservableCollection<Transaction> transactions)
        {
            this.transactions = transactions;
            AddTransactionCommand = new Command(AddTransaction);
        }

        public AddTransactionViewModel(ObservableCollection<Transaction> transactions, Transaction transaction)
        {
            this.transactions = transactions;
            this.transaction = transaction;
            AddTransactionCommand = new Command(EditTransaction);

            PriceEntry = transaction.Price;
            CategoryEntry = transaction.Category;
        }

        public void AddTransaction()                                                                                
        {
            transactions.Insert(0, new Transaction(CategoryEntry, PriceEntry));
            ChangeTransactionFile.SaveData(transactions);
        }       

        public void EditTransaction()
        {
            transaction.Price = PriceEntry;
            transaction.Category = CategoryEntry;
            
            ChangeTransactionFile.SaveData(transactions);
        }
    }
}
