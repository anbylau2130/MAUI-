using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Kingdee.App.ViewModels;

namespace Com.Kingdee.App.Views;

public partial class FriendsPage : ContentPage
{
    private FriendsViewModel vm = new FriendsViewModel();
    public FriendsPage()
    {
        vm= new FriendsViewModel();
        InitializeComponent();
    }
}