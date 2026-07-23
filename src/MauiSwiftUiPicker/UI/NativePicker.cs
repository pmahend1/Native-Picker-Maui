namespace MauiSwiftUiPicker.UI;

public class NativePicker : View
{
    public static readonly BindableProperty ItemsSourceProperty = BindableProperty.Create(propertyName: nameof(ItemsSource),
                                                                                          returnType: typeof(IList<string>),
                                                                                          declaringType: typeof(NativePicker),
                                                                                          defaultValue: new List<string>());
    public IList<string> ItemsSource
    {
        get => (IList<string>)GetValue(ItemsSourceProperty);
        set => SetValue(ItemsSourceProperty, value);
    }

    public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create(propertyName: nameof(SelectedItem),
                                                                                           returnType: typeof(string),
                                                                                           declaringType: typeof(NativePicker),
                                                                                           defaultValue: default(string),
                                                                                           defaultBindingMode: BindingMode.TwoWay);

    public string SelectedItem
    {
        get => (string)GetValue(SelectedItemProperty);
        set => SetValue(SelectedItemProperty, value);
    }
}
