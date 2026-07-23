using MauiSwiftUiPicker.UI;
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
			handlers.AddHandler(typeof(NativePicker), typeof(NativePickerHandler));
		});
#endif
		return builder.Build();
	}
}
