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
        private string player = "Evan Reed";

        public CharacterListView()
            : base("")
        {
            _characterService = new LocalCharacterService();
            Draw();
            LoadCharacters();
            this.Title = player + "'s Character List";
        }

        public void LoadCharacters()
        {
            _characters = _characterService.GetAllCharacters();
            _characterListView.SetSource(
                _characters.ConvertAll(c =>
                    $"{c.CharacterName} Level: {c.Level} {c.ClassListAsString()}"
                )
            );
        }
    }
}
