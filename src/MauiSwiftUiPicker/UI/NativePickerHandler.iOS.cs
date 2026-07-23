using Microsoft.Maui.Handlers;
using SwiftUIPicker;
using UIKit;

namespace MauiSwiftUiPicker.UI;

public partial class NativePickerHandler : ViewHandler<NativePicker, UIView>
{
    public static PropertyMapper<NativePicker, NativePickerHandler> Mapper =
        new(ViewHandler.ViewMapper)
        {
            [nameof(NativePicker.SelectedItem)] = MapSelectedItem,
        };

    PickerBridge? _bridge;

    public NativePickerHandler() : base(Mapper) { }

    protected override UIView CreatePlatformView()
    {
        _bridge = new PickerBridge(VirtualView.ItemsSource ?? new List<string>(), VirtualView.SelectedItem ?? "");
        return _bridge?.UiView ?? new UIView();
    }

    public static void MapSelectedItem(NativePickerHandler handler, NativePicker view)
    {
        handler._bridge?.SetSelected(view.SelectedItem);
    }
}