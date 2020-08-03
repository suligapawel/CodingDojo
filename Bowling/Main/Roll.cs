namespace CodingDojo.Bowling.Main
{
    public class Roll
    {
        public int KnockedPins { get; }

        public Roll(int knockedPins)
        {
            KnockedPins = knockedPins;
        }

        public Roll AddKnockedDownPins(Roll otherRoll) => new Roll(KnockedPins + otherRoll.KnockedPins);
    }
}