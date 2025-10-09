using System.Collections.Generic;
using myTuiProj.Domain.Models;
using myTuiProj.Services.LocalServices;
using myTuiProj.Services.ServiceInterfaces;
using myTuiProj.Services.UIServices;
using Terminal.Gui;

namespace myTuiProj.Views
{
    public partial class CharacterListView : Window
    {
        public ListView _characterListView;
        public Button _backButton;

        private void Init()
        {
            _characterListView = new ListView
            {
                X = 0,
                Y = 1,
                Width = Dim.Fill(),
                Height = Dim.Fill(),
            };
            _backButton = new Button("Back" + NavigationService.SeePrevious()) { X = 10, Y = 10 };
            _backButton.Clicked += () => NavigationService.Back();
            Add(_characterListView);
            Add(_backButton);
        }
    }
}
