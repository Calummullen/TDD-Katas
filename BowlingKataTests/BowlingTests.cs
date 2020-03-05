using System;
using System.Collections.Generic;
using System.Text;
using BowlingKata;
using NUnit.Framework;

namespace BowlingKataTests
{
    [TestFixture]
    public class BowlingTests
    {
        private Game _game;
        [SetUp]
        public void Setup()
        {
            _game = new Game();
        }

        private void RollMany(int rolls, int pins)
        {
            for (var i = 0; i < rolls; i++)
            {
                _game.Roll(pins);
            }
        }

        [Test]
        public void GutterGameReturnsScoreOfZero()
        {
            RollMany(20, 0);
            Assert.AreEqual(0, _game.Score());
        }

        [Test]
        public void AllOnesGameReturnsScoreOf20()
        {
            RollMany(20, 1);
            Assert.AreEqual(20, _game.Score());
        }

        [Test]
        public void GettingASpareDoublesTheValueOfTheNextRoll()
        {
            _game.Roll(5);
            _game.Roll(5);
            _game.Roll(3);
            _game.Roll(5);
            _game.Roll(5);
            _game.Roll(3);
            RollMany(14, 0);
            Assert.AreEqual(29, _game.Score());
        }

        [Test]
        public void GettingAStrikeDoublesTheValueOfTheNextTwoRolls()
        {
            _game.Roll(10);
            _game.Roll(3);
            _game.Roll(4);
            RollMany(17, 0);
            Assert.AreEqual(24, _game.Score());
        }

        [Test]
        public void PerfectGameScores300()
        {
            RollMany(12, 10);
            Assert.AreEqual(300, _game.Score());
        }

        [Test]
        public void GameReturnsCorrectValueAfterFullGame()
        {
            _game.Roll(6);
            _game.Roll(2);
            _game.Roll(3);
            _game.Roll(7);
            _game.Roll(10);
            _game.Roll(8);
            _game.Roll(2);
            _game.Roll(7);
            _game.Roll(3);
            _game.Roll(7);
            _game.Roll(1);
            _game.Roll(4);
            _game.Roll(3);
            _game.Roll(4);
            _game.Roll(2);
            _game.Roll(10);
            _game.Roll(8);
            _game.Roll(1);
            Assert.AreEqual(131, _game.Score());
        }
    }
}
