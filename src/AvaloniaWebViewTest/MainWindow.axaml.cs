using Avalonia.Controls;
using WebViewControl;

namespace AvaloniaWebViewTest;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        WebView.Settings.OsrEnabled = false;

        InitializeComponent();
    }
}