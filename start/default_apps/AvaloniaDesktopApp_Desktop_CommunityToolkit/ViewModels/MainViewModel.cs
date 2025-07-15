using System.Reflection;
using Avalonia;

namespace AvaloniaDesktopApp_Desktop_CommunityToolkit.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public string AvaloniaVersion => Assembly.GetAssembly(typeof(Avalonia.Controls.Button)).GetName().Version.ToString();

    // Retrieves the current .NET version
    public string DotNetVersion = System.Environment.Version.ToString();

    public string Greeting => ($"Welcome to Avalonia {AvaloniaVersion} and .NET Core {DotNetVersion}!");
}
 