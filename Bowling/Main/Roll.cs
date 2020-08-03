using System;

namespace CodingDojo.Bowling.Main
{
    public sealed class Roll
    {
        public int KnockedPins { get; }

        private Roll(int knockedPins)
        {
            KnockedPins = knockedPins;
        }

        public static Roll Of(int knockedPins) => new Roll(knockedPins);
        public static Roll Copy(Roll otherRoll) => Roll.Of(otherRoll.KnockedPins);

        public Roll AddKnockedDownPins(Roll otherRoll) => this + otherRoll;

        public static Roll operator +(Roll rollA, Roll rollB)
        {
            int addResult = rollA.KnockedPins + rollB.KnockedPins;
            return Roll.Of(addResult);
        }
    }
}