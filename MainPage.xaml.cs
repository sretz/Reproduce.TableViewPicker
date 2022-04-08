namespace Reproduce.TableViewPicker;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();

		canon.ItemsSource = new string[]
		{
			"Independence",
			"Jerusalem",
		};
		//canon.SelectedItem = "Independence";
	}

	protected override void OnDisappearing()
	{
		base.OnDisappearing();
	}
}
