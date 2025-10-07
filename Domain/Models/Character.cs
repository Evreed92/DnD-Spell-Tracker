using myTuiProj.Domain.SpellStructs;

namespace myTuiProj.Domain.Models
{
    public class Character
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        // Removed for Debugging
        //public Dictionary<SpellLevel, List<Spell>> KnownSpells { get; set; } = new();
        //public Dictionary<SpellLevel, List<Spell>> PreparedSpells { get; set; } = new();
    }
}
