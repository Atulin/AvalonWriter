using Avalonia.Controls;
using Avalonia.Input;

namespace AvalonWriter.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void InputElement_OnPointerPressed(object? sender, PointerPressedEventArgs e)
    {
        if (e.Source is not StackPanel { Name: "TopBar" }) return;
        BeginMoveDrag(e);
    }
}