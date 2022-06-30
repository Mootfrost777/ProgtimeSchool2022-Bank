namespace MauiApp1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

	private void MenuItem_Clicked(object sender, EventArgs e)
	{
		if (App.Current.UserAppTheme == AppTheme.Dark)
			App.Current.UserAppTheme = AppTheme.Light;
		else App.Current.UserAppTheme = AppTheme.Dark;
	}
}
