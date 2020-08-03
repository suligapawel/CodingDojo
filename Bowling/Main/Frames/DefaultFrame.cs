namespace CodingDojo.Bowling.Main.Frames
{
    public class DefaultFrame : IFrame
    {
        public Roll FirstRoll { get; }
        private readonly Roll _secondRoll;

        public DefaultFrame(int firstRoll, int secondRoll)
        {
            FirstRoll = new Roll(firstRoll);
            _secondRoll = new Roll(secondRoll);
        }

        public int Score() => FirstRoll.KnockedPins + _secondRoll.KnockedPins;
        public void TryAddBonus(IFrame frame) { }
    }
}