using System.Collections.Generic;
using myTuiProj.Domain.Models;
using myTuiProj.Services.LocalServices;
using myTuiProj.Services.ServiceInterfaces;
using myTuiProj.Services.UIServices;
using myTuiProj.Views;
using Terminal.Gui;

namespace myTuiProj.Views
{
    //CharacterListView.Designer
    public partial class CharacterListView : Window
    {
        public ListView _characterListView;
        public Button _backButton;

        public override ColorScheme ColorScheme { get; set; }

        private void Draw()
        {
            ColorScheme = new ColorScheme();
            ColorScheme.Focus = new Terminal.Gui.Attribute(Color.Black, Color.Cyan);
            _characterListView = new ListView
            {
                X = 0,
                Y = 1,
                Width = Dim.Fill(),
                Height = Dim.Fill(),
            };

            this.Add(_characterListView);
        }
    }
}
