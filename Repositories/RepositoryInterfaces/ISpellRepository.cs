using myTuiProj.Domain.Models;

namespace myTuiProj.Repositories.RepositoryInterfaces
{
    interface ISpellRepository
    {
        List<Spell> GetAllSpells();
        void Add(Spell spell);
        void Update(Spell spell);
        void Delete(Spell spell);
        Spell? GetById(int id);
        Spell? GetByName(String name);
        //Other functions
        //
        //getspellsbyschool(string school)
        //getspellsbytag
        //getspellsbylevel
        //
    }
}
