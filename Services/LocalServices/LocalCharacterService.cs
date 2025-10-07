using myTuiProj.Domain.Models;
using myTuiProj.Repositories.LocalRepositories;
using myTuiProj.Services.ServiceInterfaces;

namespace myTuiProj.Services.LocalServices
{
    public class LocalCharacterService : ICharacterService
    {
        private LocalCharacterRepository _characterRepo { get; set; }

        public LocalCharacterService()
        {
            _characterRepo = new LocalCharacterRepository();
        }

        public List<Character>? GetAllCharacters()
        {
            return _characterRepo.GetAllCharacters();
        }

        public Character? GetCharacterByName(string name)
        {
            return null;
        }

        public Character? GetCharacterById(int id)
        {
            return null;
        }
    }
}
