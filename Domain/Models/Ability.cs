using myTuiProj.Domain.CharacterStructs;

namespace myTuiProj.Domain.Models
{
    public class Ability
    {
        public AbilityName Name { get; set; }
        public string shortName { get; set; }
        public int score { get; set; }
        public int modifier { get; set; }

        public Ability(AbilityName name)
        {
            try
            {
                this.Name = name;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void GenerateScore() { }

        public void CalculateModifier() { }

        public void CreateShortName() { }
    }
}
