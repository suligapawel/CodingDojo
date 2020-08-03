using System.Collections.Generic;

namespace CodingDojo.Bowling.Main.Frames
{
    public interface IFrame
    {
        int Score();
        int ScoreAfterFirstRoll();

        void TryAddBonus(IFrame actualFrame);
    }
}
