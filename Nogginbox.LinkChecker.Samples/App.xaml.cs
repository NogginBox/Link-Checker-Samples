namespace Nogginbox.LinkChecker.Samples;

public partial class App : Application
{
	public App()
	{
        AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
        InitializeComponent();

		MainPage = new AppShell();
	}

    private void OnUnhandledException(object? sender, UnhandledExceptionEventArgs e)
    {
        System.Diagnostics.Debug.WriteLine($"Unhandled - Error: {e.ExceptionObject}");
    }
}