using System;

namespace CodingDojo.Tennis.Main
{
    public class Player
    {
        private const int ADVANTAGE = 4;
        private const int WINNER = 5;

        private readonly PlayerId _id;

        public int ScoredPoints { get; private set; }

        public bool IsAdvantage => ScoredPoints == ADVANTAGE;

        public Player(PlayerId id)
        {
            _id = id;
            ScoredPoints = 0;
        }

        public void ScorePoint()
        {
            if (!IsWinner())
                ScoredPoints++;
        }

        internal void Deuce()
        {
            ScoredPoints--;
        }

        internal bool IsScoredPlayer(PlayerId playerId) => _id.Equals(playerId);

        internal void Win()
        {
            ScoredPoints++;
        }

        private bool IsWinner() => ScoredPoints == WINNER;
    }

    public class PlayerId
    {
        public Guid Id { get; }

        public PlayerId(Guid id)
        {
            Id = id;
        }

        public override bool Equals(object obj) => obj is PlayerId id && Id.Equals(id.Id);
        public override int GetHashCode() => HashCode.Combine(Id);
    }
}