using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeApp
{
    public class GameModel
    {
        public string[,] Board { get; private set; }
        public string CurrentPlayer { get; private set; }
        public int MoveCount { get; private set; }

        public GameModel()
        {
            Board = new string[3, 3];
            CurrentPlayer = "X"; 
            MoveCount = 0;
        }

        public void MakeMove(int row, int col)
        {
            if (Board[row, col] == null)
            {
                Board[row, col] = CurrentPlayer;
                MoveCount++;
            }
        }

        public bool CheckForWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (Board[i, 0] == CurrentPlayer && Board[i, 1] == CurrentPlayer && Board[i, 2] == CurrentPlayer)
                    return true;
                if (Board[0, i] == CurrentPlayer && Board[1, i] == CurrentPlayer && Board[2, i] == CurrentPlayer)
                    return true;
            }

            if (Board[0, 0] == CurrentPlayer && Board[1, 1] == CurrentPlayer && Board[2, 2] == CurrentPlayer)
                return true;

            if (Board[0, 2] == CurrentPlayer && Board[1, 1] == CurrentPlayer && Board[2, 0] == CurrentPlayer)
                return true;

            return false;
        }

        public bool IsDraw()
        {
            return MoveCount >= 9;
        }

        public void SwitchPlayer()
        {
            CurrentPlayer = CurrentPlayer == "X" ? "O" : "X";
        }

        public void RestartGame()
        {
            Board = new string[3, 3];
            CurrentPlayer = "X";
            MoveCount = 0;
        }
    }
}
