using MauiApp1.ViewModel;
namespace MauiApp1.View;

public partial class TransactionView : ContentPage
{
	public TransactionView()
	{
		InitializeComponent();

		BindingContext = new TransactionViewModel(Navigation);
	}
}