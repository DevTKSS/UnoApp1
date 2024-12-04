using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoApp1.Presentation.MainViewModels;

public partial class SettingsViewModel:ObservableObject
{

    //private INavigator _navigator;

    public SettingsViewModel()//IStringLocalizer localizer,
        //IOptions<AppConfig> appInfo,
        //IAuthenticationService authentication,
        //INavigator navigator)
    {
       // _navigator = navigator;

       // Title = "Settings";
        //Title += $" - {localizer["ApplicationName"]}";
        //Title += $" - {appInfo?.Value?.Environment}";
        // GoToSecond = new AsyncRelayCommand(GoToSecondView);
        // Logout = new AsyncRelayCommand(DoLogout);
    }
   // public string? Title { get; }
}

