using MauiSwiftUiPicker.UI;

namespace MauiSwiftUiPicker;

public partial class MainPage
{
	public MainPage()
	{
		InitializeComponent();
		Content = new VerticalStackLayout()
		{
			new Label() { Text = "Here is picker" },
			new NativePicker { ItemsSource = new List<string> { "Tom", "Dick", "Harry" }, SelectedItem = "Tom" }

		};
/*
#if IOS
		try
		{
			System.Diagnostics.Debug.WriteLine("STEP 1: before construct");
			var bridge = new PickerBridge(new List<string> { "A" }, "A");
			System.Diagnostics.Debug.WriteLine("STEP 2: after construct");
			var view = bridge.UiView;
			System.Diagnostics.Debug.WriteLine("STEP 3: after UiView, type=" + view?.GetType());
		}
		catch (Exception ex)
		{
			System.Diagnostics.Debug.WriteLine("CAUGHT: " + ex);
		}
#endif
*/
	}
	
}
