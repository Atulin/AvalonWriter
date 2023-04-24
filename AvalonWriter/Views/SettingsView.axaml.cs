using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvalonWriter.ViewModels;

namespace AvalonWriter.Views;

public partial class SettingsView : UserControl
{
    public SettingsView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        DataContext = new SettingsViewModel();
    }
}