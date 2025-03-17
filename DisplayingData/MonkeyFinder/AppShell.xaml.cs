namespace MonkeyFinder;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

    // nameof(Details) == "DetailsPage"
    Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
	}
}