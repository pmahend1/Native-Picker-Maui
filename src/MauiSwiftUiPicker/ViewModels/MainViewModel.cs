using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiSwiftUiPicker.ViewModels;

public partial class MainViewModel : ObservableObject
{
    public ObservableCollection<string> Genres { get; set; } = ["Black Metal", "Death Metal", "DeathCore", "Pop"];

    [ObservableProperty] public partial string SelectedGenre { get; set; } = "Black Metal";
}