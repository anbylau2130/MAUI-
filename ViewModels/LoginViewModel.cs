using Com.Kingdee.App.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Com.Kingdee.App.ViewModels;

[ObservableObject]
public partial class LoginViewModel
{
    [ObservableProperty]
    private string userName;
    [ObservableProperty]
    private string password;
    [ObservableProperty]
    private bool activityIndicatorIsRunning = true;


    [RelayCommand]
    private void Submit()
    {
        Console.WriteLine("Submit");
    }
    [RelayCommand]
    private async void Register()
    {
        //设置LoginPage ProgressBar
        for (double i = 0; i < 1; i+=0.1)
        {
            await LoginPage.LoginProgressBar.ProgressTo(i,200,Easing.Linear);
        }

        await Application.Current.MainPage.DisplayAlert("register", "you entered password", "OK");
    }

    [RelayCommand]
    private void Forget()
    {
        Console.WriteLine("Forget");
    }

    [RelayCommand]
    private void EditorCompleted()
    {
        Console.WriteLine("Completed");
    }

}