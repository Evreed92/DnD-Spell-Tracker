using Terminal.Gui;

namespace myTuiProj.Services.UIServices
{
    public class NavigationService
    {
        private static readonly Stack<Window> _history = new();

        public static void Show(Window next)
        {
            var top = Application.Top;
            if (top.Subviews.Count > 0 && top.Subviews[0] is Window current)
            {
                _history.Push(current);
            }

            top.RemoveAll();
            top.Add(next);
            next.SetFocus();
            Application.Refresh();
        }

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
    }
}
