using System.Collections.Generic;
using myTuiProj.Domain.Models;
using myTuiProj.Services.LocalServices;
using myTuiProj.Services.ServiceInterfaces;
using Terminal.Gui;

namespace myTuiProj.Views
{
    public partial class CharacterListView : Window
    {
        public ListView _characterListView;

        private void Init()
        {
            _characterListView = new ListView
            {
                X = 0,
                Y = 1,
                Width = Dim.Fill(),
                Height = Dim.Fill(),
            };

            Add(_characterListView);
        }
    }
}
