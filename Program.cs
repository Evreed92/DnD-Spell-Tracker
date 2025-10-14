using myTuiProj;
using myTuiProj.Services.UIServices;
using myTuiProj.Views;
using Terminal.Gui;

Application.Init();

try
{
    //Application.Run(new MyView());
    Application.Run(new MainWindow());
}
finally
{
    Application.Shutdown();
}
