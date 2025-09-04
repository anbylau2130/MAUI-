using Com.Kingdee.App.ViewModels;

namespace Com.Kingdee.App.Views
{
    public partial class MainPage : ContentPage
    {

        private MainViewModel vm = new MainViewModel();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = vm;
        }
        
    }
}
