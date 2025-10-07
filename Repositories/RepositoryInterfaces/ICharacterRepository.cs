using myTuiProj.Domain.Models;

namespace myTuiProj.Repositories.RepositoryInterfaces
{
    interface ICharacterRepository
    {
        List<Character> GetAllCharacters();
        Character? GetByName(string name);
        void AddCharacter(Character character);
        void DeleteCharacter(Character character);
    }
}
