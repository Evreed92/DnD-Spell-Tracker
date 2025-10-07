namespace myTuiProj.Domain.SpellStructs
{
    public class SpellRange
    {
        public int Distance { get; set; }
        public string Unit { get; set; }

        public bool IsSelf =>
            Distance == 0 && Unit.Equals("Self", StringComparison.OrdinalIgnoreCase);
        public bool IsTouch =>
            Distance == 0 && Unit.Equals("Touch", StringComparison.OrdinalIgnoreCase);
    }
}
