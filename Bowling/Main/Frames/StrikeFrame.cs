namespace CodingDojo.Bowling.Main.Frames
{
    public class StrikeFrame : IFrame
    {
        private const int STRIKE_POINTS = 10;
        private Roll _bonus;

        public Roll FirstRoll => Roll.Of(STRIKE_POINTS);
        public int Score() => STRIKE_POINTS + (_bonus?.KnockedPins ?? 0);

        public void TryAddBonus(IFrame actualFrame)
        {
            if (_bonus == null)
            {
                _bonus = Roll.Of(actualFrame.Score());
            }
            else
            {
                _bonus = _bonus.AddKnockedDownPins(actualFrame.FirstRoll);
            }
        }
    }
}
