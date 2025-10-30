using myTuiProj.Domain.Models;
using myTuiProj.Domain.SpellStructs;

namespace myTuiProj.Domain.Models
{
    public class Character
    {
        //Player Information
        public string Player_Name { get; set; } = string.empty;

        //Basic Character Information
        public string Name { get; set; } = string.empty;
        public int Level { get; set; }
        public Race Race { get; set; }
        public ClassData Class { get; set; }

        public Dictionary<Ability, int> AbilityScores { get; set; }
        public Dictionary<Ability, int> AbiliityModifiers { get; set; }
        public List<Proficiency> SkillProficiencies { get; set; }
        public List<SpellSummary> KnownSpells { get; set; }
        public List<EquipmentItem> Equipment { get; set; }

        public int HitPoints { get; set; }
        public int ArmorClass { get; set; }

        public Background Background { get; set; }
    }
}
