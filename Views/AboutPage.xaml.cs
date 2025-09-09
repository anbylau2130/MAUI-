using Com.Kingdee.App.ViewModels;

namespace Com.Kingdee.App.Views;

public partial class AboutPage : ContentPage
{
    private AboutViewModel vm = new AboutViewModel();
	public AboutPage()
	{
        BindingContext = vm;
        InitializeComponent();
    }
}