using System.Text.Json;
using myTuiProj.Domain.Models;
using myTuiProj.Repositories.RepositoryInterfaces;

namespace myTuiProj.Repositories.LocalRepositories
{
    class LocalCharacterRepository : ICharacterRepository
    {
        //implement from LocalData jsons for testing
        public List<Character> GetAllCharacters()
        {
            string json = File.ReadAllText("LocalData/characters.json");
            if (json == null)
            {
                return null;
            }
            return JsonSerializer.Deserialize<List<Character>>(json)!;
        }

        public Character? GetByName(string name)
        {
            return null;
        }

        public void AddCharacter(Character character) { }

        public void DeleteCharacter(Character character) { }
    }
}
