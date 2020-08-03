using CodingDojo.Bowling.Main.Frames;
using System.Collections.Generic;
using System.Linq;

namespace CodingDojo.Bowling
{
    public class TheGame
    {
        private readonly LinkedList<IFrame> _frames;
        private readonly Bonus _bonus;

        public TheGame(Bonus bonus)
        {
            _frames = new LinkedList<IFrame>();
            _bonus = bonus;
        }

        public int Score() => _frames.Sum(frame => frame.Score());

        public void Roll(IFrame actualFrame)
        {
            bool isFirstRoll = _frames.Count == 0;
            if (isFirstRoll)
            {
                AddFrameToScoring(actualFrame);
                return;
            }

            var previousFrame = _frames.Last;
            var twoBeforeFrame = previousFrame.Previous;

            AddFrameToScoring(actualFrame);
            _bonus.Add(actualFrame, previousFrame.Value, twoBeforeFrame?.Value);
        }

        private void AddFrameToScoring(IFrame actualFrame)
        {
            _frames.AddLast(actualFrame);
        }

        public void AddFinalBonus(IFrame bonusFrame)
        {
            _bonus.AddFinal(_frames, bonusFrame);
        }
    }
}