using CommunityToolkit.Mvvm.ComponentModel;

namespace Com.Kingdee.App.ViewModels;

[ObservableObject]
public partial class AboutViewModel
{
    [ObservableProperty]
    private string appVersion;
    public AboutViewModel()
    {
        appVersion = "1.0.0";
    }
}