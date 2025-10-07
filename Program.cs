using myTuiProj;
using myTuiProj.Views;
using Terminal.Gui;

Application.Init();

try
{
    //Application.Run(new MyView());
    Application.Run(new CharacterListView());
}
finally
{
    Application.Shutdown();
}
