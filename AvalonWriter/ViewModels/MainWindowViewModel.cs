using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvalonWriter.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";
    
    [ObservableProperty]
    private int _counter = 0;

    [ObservableProperty]
    private int _amount = 1;

    [RelayCommand]
    private void Increment()
    {
        Counter += Amount;
    }

    [RelayCommand]
    private void Decrement()
    {
        Counter -= Amount;
    }
}
