using Terminal.Gui;

namespace myTuiProj.Services.UIServices
{
    public class NavigationService
    {
        private static readonly Stack<Window> _history = new();

        public static Window Init(Window initial)
        {
            _history.Push(initial);
            return initial;
        }

        public static Window Show(Window next)
        {
            return (next);
        }
        /*
                public static void Back()
                {
                    var top = Application.Top;
        
                    if (_history.Count == 0)
                    {
                        Application.RequestStop();
                        return;
                    }
        
                    var previous = _history.Pop();
                    top.RemoveAll();
                    top.Add(previous);
                    previous.SetFocus();
                    Application.Refresh();
                }
        
                public static string SeePrevious()
                {
                    var top = Application.Top;
        
                    if (_history.Count > 0)
                    {
                        var previous = _history.Peek();
                        return previous.Title.ToString();
                    }
        
                    return "";
                }
        */
    }
}
