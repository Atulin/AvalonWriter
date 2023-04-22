using System;
using Avalonia.Controls;
using AvalonWriter.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvalonWriter.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private Control _content;
    
    public MainWindowViewModel()
    {
        _content = Content = new MainView();
    }

    [RelayCommand]
    private void NewWindow() => Content = new SettingsView();

    [RelayCommand]
    private void MainView() => Content = new MainView();
}
