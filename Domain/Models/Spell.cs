using myTuiProj.Domain.SpellStructs;

namespace myTuiProj.Domain.Models
{
    public class Spell
    {
        //Basic information
        public int Id { get; set; }
        public string Name { get; set; }

        //Spell attributes as Enums
        public SpellSchool School { get; set; }
        public SpellLevel Level { get; set; }
        public DamageType DamageType { get; set; }
        public AreaType AreaType { get; set; }

        //Spell attributes as Classes
        public SpellRange Range { get; set; }
        public SpellDuration Duration { get; set; }

        //Additional information
        public string Description { get; set; }
        public List<string> ClassAvailability { get; set; }
        public bool IsRitual { get; set; }

        //Additional potential information
        //Damage Dice Per level
        //Damage dice per damage type
        //Non damage effects like "prone" or "sleep"
    }
}
