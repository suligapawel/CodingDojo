namespace CodingDojo.Bowling.Main.Frames
{
    public class StrikeFrame : IFrame
    {
        private const int STRIKE_POINTS = 10;
        private Roll? _bonus;

        public int Score() => _bonus + STRIKE_POINTS;
        public int ScoreAfterFirstRoll() => STRIKE_POINTS;

        public void TryAddBonus(IFrame actualFrame)
        {
            if (_bonus == null)
            {
                _bonus = Roll.Of(actualFrame.Score());
            }
            else
            {
                _bonus = Roll.Of(_bonus + actualFrame.ScoreAfterFirstRoll());
            }
        }
    }
}
