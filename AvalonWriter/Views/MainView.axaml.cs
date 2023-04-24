using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvalonWriter.ViewModels;

namespace AvalonWriter.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        DataContext = new MainViewModel();
    }
}