using CommunityToolkit.Mvvm.ComponentModel;

namespace Com.Kingdee.App.Models;

[ObservableObject]
public partial class Preference
{
    [ObservableProperty]
    private string preferencePrompt;
    [ObservableProperty]
    private string preferenceValue;
}