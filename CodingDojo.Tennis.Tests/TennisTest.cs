using CodingDojo.Tennis.Main;
using NUnit.Framework;
using System;

namespace CodingDojo.Tennis.Tests
{
    public class Tests
    {
        private PlayerId _anyFirstPlayerId;
        private PlayerId _anySecondPlayerId;
        private TheGame _anyGame;

        [SetUp]
        public void Setup()
        {
            _anyFirstPlayerId = new PlayerId(Guid.NewGuid());
            _anySecondPlayerId = new PlayerId(Guid.NewGuid());
            _anyGame = new TheGame(_anyFirstPlayerId, _anySecondPlayerId);
        }

        [Test]
        public void ShouldStartTheGameWithScoreZero_Zero()
        {
            string result = _anyGame.GetScore();

            Assert.AreEqual("0:0", result);
        }

        [Test]
        public void ShouldAddFifteenPointToPlayerOneWhenHeScoredPoints()
        {
            _anyGame.ScoredBy(_anyFirstPlayerId);

            Assert.AreEqual("15:0", _anyGame.GetScore());
        }

        [Test]
        public void ShouldAddFifteenPointToPlayerOneWhenHeScoredAnotherPoints()
        {
            _anyGame.ScoredBy(_anyFirstPlayerId);

            _anyGame.ScoredBy(_anyFirstPlayerId);

            Assert.AreEqual("30:0", _anyGame.GetScore());
        }

        [Test]
        public void ShouldAddTenPointToPlayerOneWhenHeScoredThirdTimePoints()
        {
            _anyGame.ScoredBy(_anyFirstPlayerId);
            _anyGame.ScoredBy(_anyFirstPlayerId);

            _anyGame.ScoredBy(_anyFirstPlayerId);

            Assert.AreEqual("40:0", _anyGame.GetScore());
        }

        [Test]
        public void ShouldAddFifteenPointToPlayerTwoWhenHeScoredPoints()
        {
            _anyGame.ScoredBy(_anyFirstPlayerId);

            _anyGame.ScoredBy(_anySecondPlayerId);

            Assert.AreEqual("15:15", _anyGame.GetScore());
        }

        [Test]
        public void ShouldAdvantageWhenScoreIs40_40AndPlayerScoredPoints()
        {
            for (int i = 0; i < 3; i++)
            {
                _anyGame.ScoredBy(_anyFirstPlayerId);
                _anyGame.ScoredBy(_anySecondPlayerId);
            }

            _anyGame.ScoredBy(_anyFirstPlayerId);

            Assert.AreEqual("Adv:40", _anyGame.GetScore());
        }

        [Test]
        public void ShouldDeuceWhenPlayerWithoutAdvancedScoredPoints()
        {
            for (int i = 0; i < 3; i++)
            {
                _anyGame.ScoredBy(_anyFirstPlayerId);
                _anyGame.ScoredBy(_anySecondPlayerId);
            }
            _anyGame.ScoredBy(_anyFirstPlayerId);

            _anyGame.ScoredBy(_anySecondPlayerId);

            Assert.AreEqual("40:40", _anyGame.GetScore());
        }

        [Test]
        public void ShouldWinPlayerWhenScoredMoreThan40PointsWithAdvanced()
        {
            for (int i = 0; i < 3; i++)
            {
                _anyGame.ScoredBy(_anyFirstPlayerId);
                _anyGame.ScoredBy(_anySecondPlayerId);
            }
            _anyGame.ScoredBy(_anyFirstPlayerId);

            _anyGame.ScoredBy(_anyFirstPlayerId);

            Assert.AreEqual("Win:40", _anyGame.GetScore());
        }

        [Test]
        public void ShouldWinPlayerWhenScoredMoreThan40Points()
        {
            for (int i = 0; i < 3; i++)
            {
                _anyGame.ScoredBy(_anyFirstPlayerId);
            }

            _anyGame.ScoredBy(_anyFirstPlayerId);

            Assert.AreEqual("Win:0", _anyGame.GetScore());
        }
    }
}