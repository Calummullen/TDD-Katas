using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BowlingKata
{
    public class Game
    {
        private readonly List<int> _listOfScores = new List<int>();
        private int _totalScore;

        public void Roll(int pins)
        {
            _listOfScores.Add(pins);
        }

        public int Score()
        {
            var frameIndex = 0;
            for (var currentFrame = 1; currentFrame < 11; currentFrame++)
            {
                if (IsSpare(frameIndex))
                {
                    ApplySpareBonus(frameIndex);
                    frameIndex += 2;
                } else if (IsStrike(frameIndex))
                {
                    ApplyStrikeBonus(frameIndex);
                    frameIndex += 1;
                }
                else
                {
                    _totalScore += _listOfScores[frameIndex] + _listOfScores[frameIndex + 1];
                    frameIndex += 2;
                }
            }

            return _totalScore;
        }

        private bool IsSpare(int index)
        {
            return _listOfScores[index] + _listOfScores[index + 1] == 10;
        }

        private bool IsStrike(int index)
        {
            return _listOfScores[index] == 10;
        }

        private void ApplyStrikeBonus(int index)
        {
            _totalScore += 10 + _listOfScores[index + 1] + _listOfScores[index + 2];
        }

        private void ApplySpareBonus(int index)
        {
            _totalScore += 10 + _listOfScores[index + 2];
        }
        
    }
}
