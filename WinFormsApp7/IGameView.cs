using System.Windows.Forms;

namespace TicTacToeApp
{
    public interface IGameView
    {
        void ShowMessage(string message);
        void EnableButtons();
        void DisableButtons();
        void ClearGrid();
        void UpdateButton(int row, int col, string text);
        bool IsPlayerStarting();
        bool IsEasyMode();

        Button[,] GridButtons { get; }
    }


}
