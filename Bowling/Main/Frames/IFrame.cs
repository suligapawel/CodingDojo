using System.Collections.Generic;

namespace CodingDojo.Bowling.Main.Frames
{
    public interface IFrame
    {
        Roll FirstRoll { get; }
        int Score();

        void TryAddBonus(IFrame actualFrame);
    }
}
