namespace MauiSwiftUiPicker.UI;

public class NativePicker : View
{
    public static readonly BindableProperty TitleProperty = BindableProperty.Create(propertyName: nameof(Title),
                                                                                    returnType: typeof(string),
                                                                                    declaringType: typeof(NativePicker),
                                                                                    defaultValue: string.Empty);

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }


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
                                                                                           defaultValue: string.Empty,
                                                                                           defaultBindingMode: BindingMode.TwoWay);

    public string SelectedItem
    {
        get => (string)GetValue(SelectedItemProperty);
        set => SetValue(SelectedItemProperty, value);
    }
}
