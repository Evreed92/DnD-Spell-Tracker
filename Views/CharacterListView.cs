using System.Collections.Generic;
using myTuiProj.Domain.Models;
using myTuiProj.Services.LocalServices;
using myTuiProj.Services.ServiceInterfaces;
using Terminal.Gui;

namespace myTuiProj.Views
{
    public partial class CharacterListView : Window
    {
        private readonly ICharacterService _characterService;
        private List<Character> _characters;

        public CharacterListView()
            : base("Character List")
        {
            _characterService = new LocalCharacterService();
            Init();
            LoadCharacters();
        }

        public void LoadCharacters()
        {
            _characters = _characterService.GetAllCharacters();
            _characterListView.SetSource(
                _characters.ConvertAll(c => $"{c.Name} ({c.Class}. {c.Level})")
            );
        }
    }
}
