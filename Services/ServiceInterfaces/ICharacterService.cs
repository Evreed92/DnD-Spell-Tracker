using myTuiProj.Domain.Models;

namespace myTuiProj.Services.ServiceInterfaces
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();

        Character? GetCharacterByName(string name);

        Character? GetCharacterById(int id);
    }
}
