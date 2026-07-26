using MauiSwiftUiPicker.ViewModels;

namespace MauiSwiftUiPicker;

public partial class MainPage
{
	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
