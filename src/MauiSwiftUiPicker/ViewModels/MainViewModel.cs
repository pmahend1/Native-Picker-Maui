using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using SwiftUIPicker;

namespace MauiSwiftUiPicker.ViewModels;

public partial class MainViewModel : ObservableObject
{
    public ObservableCollection<string> Genres { get; set; } =
    [
        "Black Metal",
        "Death Metal",
        "DeathCore",
        "Pop"
    ];

    [ObservableProperty]
    public partial string SelectedGenre { get; set; } = "Black Metal";

    public List<string> PickerKinds { get; set; } =
    [
        nameof(NativePickerStyle.Automatic),
        nameof(NativePickerStyle.Inline),
        nameof(NativePickerStyle.Menu),
        nameof(NativePickerStyle.Segmented),
        nameof(NativePickerStyle.Wheel),
        nameof(NativePickerStyle.NavigationLink),
        nameof(NativePickerStyle.Palette)
    ];

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(SelectedPickerKind))]
    public partial string SelectedPickerKindText { get; set; } = nameof(NativePickerStyle.Automatic);

    public NativePickerStyle SelectedPickerKind => Enum.TryParse(SelectedPickerKindText, true, out NativePickerStyle kind) ? kind : NativePickerStyle.Automatic;
}
