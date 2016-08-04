using System;
using System.Collections.Generic;

namespace TennisBusiness
{
    public class Game
    {

        public Dictionary<int,int> Scores;
        private string p01= "Player 1";
        private string p11="Player 2";

        public Game(int p0, int p1)
        {
            Scores = new Dictionary<int, int>();
            Scores.Add(1, p0);
            Scores.Add(2, p1);
        }

        public Game(int p0, int p1, string p01, string p11) : this(p0, p1)
        {
            this.p01 = p01;
            this.p11 = p11;
        }

        public int PlayerOne { get { return Scores[1]; } }
        public int PlayerTwo { get { return Scores[2]; } }

        public void ScorePoint(int whichPlayer)
        {
            int ScoreToAdd = 0;

            if (Scores[GetOtherPlayer(whichPlayer)] == 50)
            {
                Scores[GetOtherPlayer(whichPlayer)] = 40;
            }
            else
            {
                switch (Scores[whichPlayer])
                {
                    case 50:
                        ScoreToAdd = 5;
                        break;

                    case 40:
                        ScoreToAdd = Scores[GetOtherPlayer(whichPlayer)] == 40 ? 10 : 15;
                        break;
                    case 30:
                        ScoreToAdd = 10;
                        break;
                    default:
                        ScoreToAdd = 15;
                        break;
                }

            }
            Scores[whichPlayer] += ScoreToAdd;

        }

        private int GetOtherPlayer(int whichPlayer)
        {
            return whichPlayer == 1 ? 2 : 1;

        }

        public override string ToString() => $"{p01} {PlayerOne} - {PlayerTwo} {p11}";
    }
}