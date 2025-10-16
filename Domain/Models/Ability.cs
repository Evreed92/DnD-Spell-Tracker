using myTuiProj.Domain.CharacterStructs;

namespace myTuiProj.Domain.Models
{
    public class Ability
    {
        public AbilityName Name { get; set; }
        public string ShortName { get; set; }
        public int Score { get; set; }
        public int Modifier { get; set; }

        public Ability(AbilityName name)
        {
            try
            {
                this.Name = name;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return;
            }
            switch (this.Name.ToString())
            {
                case "Strength":
                    this.ShortName = "STR";
                    break;
                case "Constitution":
                    this.ShortName = "CON";
                    break;
                case "Dexterity":
                    this.ShortName = "DEX";
                    break;
                case "Wisdom":
                    this.ShortName = "WIS";
                    break;
                case "Intelligence":
                    this.ShortName = "INT";
                    break;
                case "Charisma":
                    this.ShortName = "CHA";
                    break;
                default:
                    break;
            }
        }

        public void GenerateScore() { }

        public void CalculateModifier() { }

        public void CreateShortName() { }
    }
}
