namespace CodingDojo.Bowling.Main.Frames
{
    public class SpareFrame : IFrame
    {
        private const int SPARE_POINTS = 10;
        private Roll _bonus;

        public Roll FirstRoll { get; }

        public SpareFrame(int knockedPins)
        {
            FirstRoll = Roll.Of(knockedPins);
        }

        public int Score() => SPARE_POINTS + (_bonus?.KnockedPins ?? 0);

        public void TryAddBonus(IFrame actualFrame)
        {
            if (_bonus == null)
                _bonus = Roll.Copy(actualFrame.FirstRoll);
        }
    }
}
