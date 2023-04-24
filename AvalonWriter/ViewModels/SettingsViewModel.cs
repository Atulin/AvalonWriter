using AvalonWriter.Services.TestService;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Serilog;

namespace AvalonWriter.ViewModels;

public partial class SettingsViewModel : ViewModelBase
{
    private readonly ITestService _dep;

    public SettingsViewModel()
    {
        _dep = new TestService(); // TODO: get this from DI
    }

    [ObservableProperty]
    private string _message = "henlo";

    
    [RelayCommand]
    public void LogCommand()
    {
        Log.Information("Number is {Number}", _dep.Number);
        Message = $"Number is {_dep.Number}";
    }
}