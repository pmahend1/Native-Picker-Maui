using CoreFoundation;
using Microsoft.Maui.Handlers;
using SwiftUIPicker;
using UIKit;

namespace MauiSwiftUiPicker.UI;

public class NativePickerHandler() : ViewHandler<NativePicker, UIView>(Mapper)
{
    private PickerBridge? _bridge;

    public static PropertyMapper<NativePicker, NativePickerHandler> Mapper = new(ViewMapper)
    {
        [nameof(NativePicker.SelectedItem)] = MapSelectedItem
    };

    protected override UIView CreatePlatformView()
    {
        _bridge = new PickerBridge(items: VirtualView.ItemsSource,
                                   selected: VirtualView.SelectedItem,
                                   title: VirtualView.Title,
                                   style: NativePickerStyle.Inline,
                                   onSelectionChanged: s =>  DispatchQueue.MainQueue.DispatchAsync(() => VirtualView.SelectedItem = s));
        return _bridge?.UiView ?? new UIView();
    }

    public static void MapSelectedItem(NativePickerHandler handler, NativePicker view)
    {
        handler._bridge?.SetSelected(view.SelectedItem);
    }
}