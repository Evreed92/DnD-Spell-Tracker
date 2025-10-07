namespace myTuiProj.Domain.SpellStructs
{
    public class SpellDuration
    {
        public DurationType Type { get; set; }
        public int? Amount { get; set; } // numerical amount. 0 for instantaneous null for concentration
        public string Unit { get; set; } //rounds, minutes, hours etc.
    }

    public enum DurationType
    {
        Instantaeous,
        Timed,
        Concentration,
    }
}
