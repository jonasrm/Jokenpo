using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo.Classes
{
    public class Game
    {
        public enum Option
        {
            Rock,
            Paper,
            Sissors,
        }

        /// <summary>
        /// Checks whether the player has won from your opponent
        /// </summary>
        /// <param name="player">Player</param>
        /// <param name="oponnent">Oponnet</param>
        /// <returns></returns>
        private bool PlayerWinner(Option player, Option oponnent)
        {
            if (player == Option.Paper && oponnent == Option.Rock) return true;
            if (player == Option.Rock && oponnent == Option.Sissors) return true;
            if (player == Option.Sissors && oponnent == Option.Paper) return true;
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        /// <returns></returns>
        public Option? CheckWinner(Option player1, Option player2)
        {
            Option? result = null;
            try
            {
                if (player1 != player2)
                {
                    if (PlayerWinner(player1, player2)) result = player1;
                    if (PlayerWinner(player2, player1)) result = player2;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }
    }
}
