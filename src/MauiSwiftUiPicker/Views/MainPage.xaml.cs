using MauiSwiftUiPicker.ViewModels;

namespace MauiSwiftUiPicker.Views;

public partial class MainPage
{
	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
