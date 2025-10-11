using myTuiProj;
using myTuiProj.Services.UIServices;
using myTuiProj.Views;
using Terminal.Gui;

Application.Init();

try
{
    //Application.Run(new MyView());
    Application.Run(NavigationService.Init(new CharacterListView()));
}
finally
{
    Application.Shutdown();
}
