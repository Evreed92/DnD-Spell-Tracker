using System.Text.Json;
using Microsoft.Extensions.Hosting;
using myTuiProj.Domain.Models;
using myTuiProj.Repositories.RepositoryInterfaces;

namespace myTuiProj.Repositories.LocalRepositories
{
    class LocalSpellRepository : ISpellRepository
    {
        //read from LocalData/spells.json for testing
        private readonly List<Spell> _spells;
        private readonly string _filePath;

        public List<Spell> GetAllSpells()
        {
            return null;
        }

        public void Add(Spell spell) { }

        public void Update(Spell spell) { }

        public void Delete(Spell spell) { }

        public Spell? GetById(int id)
        {
            return null;
        }

        public Spell? GetByName(String name)
        {
            return null;
        }
    }
}
