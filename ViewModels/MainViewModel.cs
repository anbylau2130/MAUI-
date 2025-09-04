using CommunityToolkit.Mvvm.ComponentModel;
namespace Com.Kingdee.App.ViewModels;

[ObservableObject]
public partial class MainViewModel
{
    public MainViewModel()
    {
        OnInitialize();
    }
    
    private  void OnInitialize()
    {
        UserName = "admin";
        Password = "123456";
    }

    [ObservableProperty]
    private string userName;
    [ObservableProperty]
    private string password;

    private void OnLogin()
    {
        //登录逻辑
    }
}