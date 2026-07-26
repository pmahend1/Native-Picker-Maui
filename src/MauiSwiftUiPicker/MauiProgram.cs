using MauiSwiftUiPicker.UI;
using MauiSwiftUiPicker.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiSwiftUiPicker;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

#if IOS
		builder.ConfigureMauiHandlers(handlers =>
		{
			handlers.AddHandler<NativePicker, NativePickerHandler>();
		});
#endif
		builder.Services.AddSingleton<MainViewModel>().AddSingleton<MainPage>();
		return builder.Build();
	}
}
