using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using AvalonWriter.Services.TestService;
using AvalonWriter.ViewModels;
using AvalonWriter.Views;
using Microsoft.Extensions.DependencyInjection;

namespace AvalonWriter;

public partial class App : Application
{
    public new static Application Current => (App)Application.Current! ?? throw new InvalidOperationException();

    public IServiceProvider Services { get; private set; } = null!;
    
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
        Services = new ServiceCollection()
            .AddSingleton<ITestService, TestService>()
            .BuildServiceProvider();

        Resources[typeof(IServiceProvider)] = Services;
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            BindingPlugins.DataValidators.RemoveAt(0);
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}