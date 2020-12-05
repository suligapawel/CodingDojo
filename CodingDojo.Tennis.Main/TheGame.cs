using System.Collections.Generic;

namespace CodingDojo.Tennis.Main
{
    public class TheGame
    {
        private static readonly Dictionary<int, string> _pointsMapper = new Dictionary<int, string>
        {
            {0, "0" }, {1, "15" }, {2, "30" },
            {3, "40" }, {4, "Adv" }, {5, "Win" }
        };

        private readonly Player _firstPlayer;
        private readonly Player _secondPlayer;

        public TheGame(PlayerId firstPlayer, PlayerId secondPlayer)
        {
            _firstPlayer = new Player(firstPlayer);
            _secondPlayer = new Player(secondPlayer);
        }

        public string GetScore()
            => _pointsMapper[_firstPlayer.ScoredPoints] + ":" + _pointsMapper[_secondPlayer.ScoredPoints];

        public void ScoredBy(PlayerId playerId)
        {
            Player scoringPlayer = _firstPlayer.IsScoredPlayer(playerId) ? _firstPlayer : _secondPlayer;
            Player losingPlayer = _firstPlayer.IsScoredPlayer(playerId) ? _secondPlayer : _firstPlayer;

            if (AnyPlayerIsAdvantage())
            {
                if (losingPlayer.IsAdvantage)
                {
                    losingPlayer.Deuce();
                    return;
                }

                if (scoringPlayer.IsAdvantage)
                {
                    scoringPlayer.Win();
                    return;
                }
            }

            scoringPlayer.ScorePoint();

            if (WinWithoutAdvantage(scoringPlayer, losingPlayer))
                scoringPlayer.Win();
        }

        private static bool WinWithoutAdvantage(Player scoringPlayer, Player losingPlayer)
            => scoringPlayer.IsAdvantage && losingPlayer.ScoredPoints < 3;

        private bool AnyPlayerIsAdvantage() => _firstPlayer.IsAdvantage || _secondPlayer.IsAdvantage;
    }
}
