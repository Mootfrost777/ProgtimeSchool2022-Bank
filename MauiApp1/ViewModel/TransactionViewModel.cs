using System.Collections.ObjectModel;
using System.Windows.Input;
using MauiApp1.Model;
using MauiApp1.View;
using MauiApp1.Helpers;

namespace MauiApp1.ViewModel
{
    public class TransactionViewModel
    {
        public ObservableCollection<Transaction> Transactions { get; set; }
                    = new();

        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand EditCommand { get; set; }

        private INavigation Navigation;

        public TransactionViewModel(INavigation navigation)
        {
            Navigation = navigation;
            
            AddCommand = new Command(async () => await AddTransaction());
            DeleteCommand = new Command<Transaction>(DeleteTransaction);
            EditCommand = new Command<Transaction>(async t => await EditTransaction(t));

            Transactions = ChangeTransactionFile.LoadData(Transactions);
        }

        private void DeleteTransaction(Transaction transaction)
        {
            Transactions.Remove(transaction);
            ChangeTransactionFile.SaveData(Transactions);
        }

        private async Task AddTransaction()
        {
            await Navigation.PushAsync(new AddTransactionView(Transactions));
        }

        private async Task EditTransaction(Transaction transac)
        {
            await Navigation.PushAsync(new AddTransactionView(Transactions, transac));
        }
    }
}
