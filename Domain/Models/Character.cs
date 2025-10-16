using myTuiProj.Domain.Models;
using myTuiProj.Domain.SpellStructs;

namespace myTuiProj.Domain.Models
{
    public class Character
    {
        public string PlayerName { get; set; }

        //Identity and Data
        public string CharacterName { get; set; }
        public string Race { get; set; } //Immportant for Stat Building
        public int Level { get; set; }
        public List<ClassData> ClassList { get; set; }

        //Stats
        public List<Ability> Abilities { get; set; }
        public int ProficiencyBonus { get; set; } //Derived from Level

        public string ClassListAsString()
        {
            string classListString = null;
            foreach (ClassData c in this.ClassList)
            {
                classListString += $"{c.ClassName}({c.ClassLevel})";
            }
            return classListString;
        }
    }
}
