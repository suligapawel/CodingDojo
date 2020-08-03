namespace CodingDojo.Bowling.Main.Frames
{
    public class SpareFrame : IFrame
    {
        private const int SPARE_POINTS = 10;

        private Roll _firstRoll;
        private Roll? _bonus;

        public SpareFrame(int knockedPins)
        {
            _firstRoll = Roll.Of(knockedPins);
        }

        public int Score() => _bonus + SPARE_POINTS;
        public int ScoreAfterFirstRoll() => _firstRoll.KnockedPins;

        public void TryAddBonus(IFrame actualFrame)
        {
            if (_bonus == null)
                _bonus = Roll.Of(actualFrame.ScoreAfterFirstRoll());
        }
    }
}
