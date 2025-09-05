using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Kingdee.App.ViewModels;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace Com.Kingdee.App.Views;

public partial class PreferencePage : ContentPage
{
    private PreferenceViewModel vm;
    public PreferencePage()
    {
        vm = new PreferenceViewModel();
        BindingContext  = vm;
        InitializeComponent();
    }

    /// <summary>
    /// 页面首次显示时
    /// </summary>
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await vm.Init();
    }

    /// <summary>
    /// 页面关闭时
    /// </summary>
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        ShowToast("test");
    }

    private async Task ShowToast(string test)
    {
        var cancellationTokenSource = new CancellationTokenSource();
        var message="saved successfully";
        ToastDuration duration = ToastDuration.Short;
        var fontSize=16;
        var toast=Toast.Make(message,duration,fontSize);
        await toast.Show(cancellationTokenSource.Token);
    }
}