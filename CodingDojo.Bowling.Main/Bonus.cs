using CodingDojo.Bowling.Main.Frames;
using System.Collections.Generic;

namespace CodingDojo.Bowling.Main
{
    public class Bonus
    {
        private bool _firstBonusRolled;

        public void AddFinal(LinkedList<IFrame> allFrames, IFrame bonusFrame)
        {
            var previousFrame = allFrames.Last;
            var twoBeforeFrame = previousFrame.Previous;

            if (_firstBonusRolled)
            {
                previousFrame.Value.TryAddBonus(bonusFrame);
                return;
            }

            _firstBonusRolled = true;
            Add(bonusFrame, previousFrame.Value, twoBeforeFrame.Value);
        }

        public void Add(IFrame bonusFrame, IFrame previousFrame, IFrame twoBeforeFrame)
        {
            previousFrame.TryAddBonus(bonusFrame);
            twoBeforeFrame?.TryAddBonus(bonusFrame);
        }
    }
}
