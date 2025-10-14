using myTuiProj.Domain.SpellStructs;

namespace myTuiProj.Domain.Models
{
    public class Character
    {
        //Identity and Progression
        public string Name { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public string Race { get; set; } //Immportant for Stat Building
        public string SubClass { get; set; }
       //Basic Main Stats
        public Dictionary<String, int> AbilityScores {get; set;}
        public Dictionary<String, int> AbilityModifiers {get; set;} //Derived from AbilityScores
       public int ProficiencyBonus {get; set;}
        //Spell Casting Details
        public string SpellCastingStat { get; set; } //From Class
        public int SpellSaveDC { get; set; } //Derived from statModifier
        public int SpellAttackBonus { get; set; } //Derived from statModifier

        public Dictionary<SpellLevel, int> SpellSlotsMax { get; set; } = new();
    */
    }
}
