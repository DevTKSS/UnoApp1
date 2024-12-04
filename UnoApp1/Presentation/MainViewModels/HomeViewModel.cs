using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoApp1.Presentation.MainViewModels;

public partial class HomeViewModel : ObservableObject
{

   // private INavigator _navigator;

    //[ObservableProperty]
    //private string? name;

    public HomeViewModel()
        //IStringLocalizer localizer,
        //IOptions<AppConfig> appInfo,
        //IAuthenticationService authentication,
        //INavigator navigator)
    {
        //_navigator = navigator;
        
       // Title = "Home";
        //Title += $" - {localizer["ApplicationName"]}";
        //Title += $" - {appInfo?.Value?.Environment}";
       // GoToSecond = new AsyncRelayCommand(GoToSecondView);
       // Logout = new AsyncRelayCommand(DoLogout);
    }
   // public string? Title { get; }

   // public ICommand GoToSecond { get; }

   // public ICommand Logout { get; }

    //private async Task GoToSecondView()
    //{
    //    await _navigator.NavigateViewModelAsync<SecondViewModel>(this, data: new Entity(Name!));
    //}

    //public async Task DoLogout(CancellationToken token)
    //{
    //    await _authentication.LogoutAsync(token);
    //}
}
