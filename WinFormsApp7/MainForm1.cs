namespace TicTacToeApp
{
    public partial class MainForm : Form, IGameView
    {
        private GamePresenter presenter;

        public MainForm()
        {
            InitializeComponent();
            presenter = new GamePresenter(this);
            presenter.StartNewGame();
        }

        // Реализация свойства GridButtons
        public Button[,] GridButtons
        {
            get { return gridButtons; }
        }

        // Обработка нажатия кнопки на игровом поле
        private void GridButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                int row = (button.Location.Y - 25) / 100; // Расчет строки
                int col = button.Location.X / 100; // Расчет столбца
                presenter.OnGridButtonClicked(row, col);
            }
        }

        // Обработчик для кнопки "Новая игра"
        private void RestartButton_Click(object sender, EventArgs e)
        {
            presenter.StartNewGame();
        }

        // Метод для отображения сообщения (например, при выигрыше или ничьей)
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Метод для активации кнопок на игровом поле
        public void EnableButtons()
        {
            foreach (var button in gridButtons)
            {
                button.Enabled = true;
            }
        }

        // Метод для деактивации кнопок на игровом поле
        public void DisableButtons()
        {
            foreach (var button in gridButtons)
            {
                button.Enabled = false;
            }
        }

        // Метод для очистки текста кнопок на игровом поле
        public void ClearGrid()
        {
            foreach (var button in gridButtons)
            {
                button.Text = string.Empty;
            }
        }

        // Метод для обновления текста кнопки по координатам
        public void UpdateButton(int row, int col, string text)
        {
            gridButtons[row, col].Text = text;
        }

        // Метод для определения, какой игрок начинает игру
        public bool IsPlayerStarting()
        {
            return playerStartsCheckbox.Checked;
        }

        // Метод для получения режима игры (легкий/сложный)
        public bool IsEasyMode()
        {
            return easyMode.Checked;
        }
    }
}
