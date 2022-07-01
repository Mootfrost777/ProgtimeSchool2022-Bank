using MauiApp1.ViewModel;
using System.Collections.ObjectModel;
using MauiApp1.Model;

namespace MauiApp1.View;

public partial class AddTransactionView : ContentPage
{
	public AddTransactionView(ObservableCollection<Transaction> transactions)
	{
		InitializeComponent();

		BindingContext = new AddTransactionViewModel(transactions);
	}

	public AddTransactionView(ObservableCollection<Transaction> transactions, Transaction transaction)
	{
        InitializeComponent();

        BindingContext = new AddTransactionViewModel(transactions, transaction);
    }
}