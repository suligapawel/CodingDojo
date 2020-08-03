namespace CodingDojo.Bowling.Main.Frames
{
    public class DefaultFrame : IFrame
    {
        private readonly Roll _firstRoll;
        private readonly Roll _secondRoll;

        public DefaultFrame(int firstKnockedPins, int secondKnockedPins)
        {
            _firstRoll = Roll.Of(firstKnockedPins);
            _secondRoll = Roll.Of(secondKnockedPins);
        }

        public int Score() => _firstRoll + _secondRoll;
        public int ScoreAfterFirstRoll() => _firstRoll.KnockedPins;

        public void TryAddBonus(IFrame frame) { }
    }
}