using CommunityToolkit.Mvvm.ComponentModel;

namespace Com.Kingdee.App.Models;

[ObservableObject]
public partial class Friend
{
    [ObservableProperty]
    private string friendName;

    [ObservableProperty]
    private double friendAge;
}