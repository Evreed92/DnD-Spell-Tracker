using myTuiProj.Domain.SpellStructs;

namespace myTuiProj.Domain.Models
{
    public class Character
    {
        //Identity and Progression
        public string Name { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        //     public string Race { get; set; }
        //     public string SubClass { get; set; }
        /* Removed for Debugging
        //Spell Casting Details
        public string SpellCastingStat { get; set; }
        public int SpellSaveDC { get; set; }
        public int SpellAttackBonus { get; set; }

        public Dictionary<SpellLevel, int> SpellSlotsMax { get; set; } = new();
    */
    }
}
