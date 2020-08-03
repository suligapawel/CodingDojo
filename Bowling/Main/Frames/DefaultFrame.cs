namespace CodingDojo.Bowling.Main.Frames
{
    public class DefaultFrame : IFrame
    {
        public Roll FirstRoll { get; }
        private readonly Roll _secondRoll;

        public DefaultFrame(int firstKnockedPins, int secondKnockedPins)
        {
            FirstRoll = Roll.Of(firstKnockedPins);
            _secondRoll = Roll.Of(secondKnockedPins);
        }

        public int Score()
        {
            Roll sumOfRolls = FirstRoll + _secondRoll;
            return sumOfRolls.KnockedPins;
        }

        public void TryAddBonus(IFrame frame) { }
    }
}