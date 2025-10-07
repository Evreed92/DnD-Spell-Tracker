using myTuiProj.Domain.Models;

namespace myTuiProj.Services.ServiceInterfaces
{
    interface ISpellService
    {
        List<Spell> GetAllSpells();
        List<Spell> GetSpellsFromListById(List<int> spellList);
        Spell? GetSpellByName(string name);
        Spell? GetSpellById(int id);
    }
}
