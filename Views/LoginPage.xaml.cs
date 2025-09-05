using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Kingdee.App.ViewModels;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Core.Views;
using CommunityToolkit.Mvvm.Messaging;

namespace Com.Kingdee.App.Views;

public partial class ConstructMessage
{

}

public partial class LoginPage : ContentPage
{
    private LoginViewModel vm = new LoginViewModel();
    public static ProgressBar LoginProgressBar;
    public LoginPage()
    {

        LoginProgressBar = new ProgressBar()
        {
            VerticalOptions = LayoutOptions.End,
        };
        
        InitializeComponent();
        //只能在InitializeComponent后面执行，否则LoginPageLayout没有初始化
        LoginPageLayout.Children.Add(LoginProgressBar);

        BindingContext = vm;


        WeakReferenceMessenger.Default.Register<ConstructMessage>(this, async (m, e) =>
        {
            await DisplayAlert("提示", "消息", "确定", "取消");
        });
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
    }

    private async void Button_OnClicked(object? sender, EventArgs e)
    {/*
      DisplayAlert("test","test","ok");

         //选择操作
          CreateAccount.Text = (
            await DisplayActionSheet(
                "how can we solve this?",
                "cancel ",
                "OK btn",
                "test1","test2"
            )
            );
        //自定义输入
        CreateAccount.Text =await DisplayPromptAsync(
            "Create Account",
            "Please enter your account name",
            "OK",
            "Cancel",
            "Account Name",
            Int32.MaxValue);

        //toast提示
          CancellationTokenSource cts = new CancellationTokenSource();
        var message= "Your account was created successfully.";
        ToastDuration duration = ToastDuration.Long;
        var fontSize = 16;
        var toast = Toast.Make(message, duration, fontSize);
        toast.Show(cts.Token);
      */


        //for (double i = 0; i < 1; i += 0.1)
        //{
        //    await LoginProgressBar.ProgressTo(i, 200, Easing.Linear);
        //}

        //CancellationTokenSource cts = new CancellationTokenSource();
        //TimeSpan duration = TimeSpan.FromSeconds(10);
        //Action action=async () =>
        //{
        //    await DisplayAlert("提示", "消息", "确定","取消");
        //};
        //var snackbarOptions= new SnackbarOptions
        //{
        //    BackgroundColor = Colors.LightGray,
        //    TextColor = Colors.Black,
        //    ActionButtonTextColor = Colors.Blue,
        //    CornerRadius = new CornerRadius(10),
        //    Font = Microsoft.Maui.Font.SystemFontOfSize(14),
        //    ActionButtonFont = Microsoft.Maui.Font.SystemFontOfSize(14)
        //};
        //var snackbar=Snackbar.Make(
        //    "提示",
        //    action,
        //    "文本内容", 
        //    duration,
        //    snackbarOptions
        //    );
        //await snackbar.Show(cts.Token);
        //Thread.Sleep(5000);
        //vm.ActivityIndicatorIsRunning = false;

        //await LoginProgressBar.ProgressTo(1, 200, Easing.Linear);

    }
}