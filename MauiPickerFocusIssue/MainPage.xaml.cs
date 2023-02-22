namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public string Text { get; set; } = "s";

	public MainPage()
	{
		InitializeComponent();


		var monkeyList = new List<string>();
		monkeyList.Add("Baboon");
		monkeyList.Add("Capuchin Monkey");
		monkeyList.Add("Blue Monkey");
		monkeyList.Add("Squirrel Monkey");
		monkeyList.Add("Golden Lion Tamarin");
		monkeyList.Add("Howler Monkey");
		monkeyList.Add("Japanese Macaque");

		MyPicker.ItemsSource = monkeyList;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

