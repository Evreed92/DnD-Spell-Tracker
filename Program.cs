using myTuiProj;
using myTuiProj.Services.UIServices;
using myTuiProj.Views;
using Terminal.Gui;

Application.Init();
var top = Application.Top;

top.Add(new Label("Press Q to Quit") { X = 1, Y = 1 });

top.KeyPress += (args) =>
{
    if (args.KeyEvent.Key == Key.Q) // Change to whatever key you want
    {
        Application.RequestStop();
        args.Handled = true;
    }
};

try
{
    //Application.Run(new MyView());
    Application.Run(NavigationService.Show(new CharacterListView()));
}
finally
{
    Application.Shutdown();
}
