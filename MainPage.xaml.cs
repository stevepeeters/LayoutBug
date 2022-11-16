namespace MauiApp2;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void AddLabel_Clicked(object sender, EventArgs e)
	{
		Label label = new() { Text = $"{Guid.NewGuid()}" };
		StackLayout.Add(label);
	}

	private void InvalidateMeasure_Clicked(object sender, EventArgs e)
	{
		this.InvalidateMeasure();
	}
}

