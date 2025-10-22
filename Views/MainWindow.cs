using myTuiProj.Views;
using Terminal.Gui;

namespace myTuiProj.Views
{
    public partial class MainWindow : Window
    {
        public override ColorScheme ColorScheme { get; set; }

        public MainWindow()
            : base("SpellTrackerApp | ctr+q to Quit")
        {
            Draw();
            CharacterListView characterListView = new CharacterListView();

            this.Add(characterListView);
        }

        private void Draw()
        {
            ColorScheme = new ColorScheme()
            {
                Normal = new Terminal.Gui.Attribute(Color.Black, Color.BrightYellow),
            };
        }
    }
}
