using Com.Kingdee.App.Models;
using Com.Kingdee.App.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Com.Kingdee.App.ViewModels;

[ObservableObject]
public partial class PreferenceViewModel
{
    [ObservableProperty]
    private List<Preference> preferenceList;
    [ObservableProperty]
    private  PreferenceService service;
    public PreferenceViewModel()
    {
        service = new ();
    }

    public async Task Init()
    {
        PreferenceList = await service.GetPreferences();
    }

    [RelayCommand]
    private void SavePreferece()
    {
        Console.WriteLine("SavePreferece");
    }
}