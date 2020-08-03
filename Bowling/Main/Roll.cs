namespace CodingDojo.Bowling.Main
{
    public struct Roll
    {
        public readonly int KnockedPins;

        private Roll(int knockedPins)
        {
            KnockedPins = knockedPins;
        }

        public static Roll Of(int knockedPins) => new Roll(knockedPins);

        public static int operator +(Roll? rollA, Roll rollB) => (rollA?.KnockedPins ?? 0) + rollB.KnockedPins;
        public static int operator +(Roll? rollA, int valuFromRollB) => (rollA?.KnockedPins ?? 0) + valuFromRollB;
    }
}