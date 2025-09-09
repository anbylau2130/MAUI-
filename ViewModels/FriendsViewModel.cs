using Com.Kingdee.App.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Com.Kingdee.App.ViewModels;

[ObservableObject]
public partial class FriendsViewModel
{
    [ObservableProperty]
    private List<Friend> friends;

    public FriendsViewModel()
    {
        friends = new List<Friend>();
    }

    
}