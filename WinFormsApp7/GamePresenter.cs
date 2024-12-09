using TicTacToeApp;

public class GamePresenter
{
    private readonly IGameView view;
    private readonly GameModel model;

    public GamePresenter(IGameView view)
    {
        this.view = view;
        this.model = new GameModel();
    }

    public void StartNewGame()
    {
        model.RestartGame();
        view.EnableButtons();
        foreach (var button in view.GridButtons)
        {
            button.Text = ""; 
        }
    }

    internal void MakeMove(int row, int col)
    {
        throw new NotImplementedException();
    }

    internal void OnGridButtonClicked(int row, int col)
    {
        throw new NotImplementedException();
    }
}
