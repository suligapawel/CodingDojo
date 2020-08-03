namespace CodingDojo.Bowling.Main
{
    public struct Roll
    {
        private readonly int _knockedPins;

        private Roll(int knockedPins)
        {
            _knockedPins = knockedPins;
        }

        public static Roll Of(int knockedPins) => new Roll(knockedPins);
        public static Roll Copy(Roll otherRoll) => Roll.Of(otherRoll._knockedPins);

        public static int operator +(Roll? rollA, Roll rollB) => (rollA?._knockedPins ?? 0) + rollB._knockedPins;
        public static int operator +(Roll? rollA, int valuFromRollB) => (rollA?._knockedPins ?? 0) + valuFromRollB;
    }
}