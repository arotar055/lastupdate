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

        // ���������� �������� GridButtons
        public Button[,] GridButtons
        {
            get { return gridButtons; }
        }

        // ��������� ������� ������ �� ������� ����
        private void GridButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                int row = (button.Location.Y - 25) / 100; // ������ ������
                int col = button.Location.X / 100; // ������ �������
                presenter.OnGridButtonClicked(row, col);
            }
        }

        // ���������� ��� ������ "����� ����"
        private void RestartButton_Click(object sender, EventArgs e)
        {
            presenter.StartNewGame();
        }

        // ����� ��� ����������� ��������� (��������, ��� �������� ��� ������)
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ����� ��� ��������� ������ �� ������� ����
        public void EnableButtons()
        {
            foreach (var button in gridButtons)
            {
                button.Enabled = true;
            }
        }

        // ����� ��� ����������� ������ �� ������� ����
        public void DisableButtons()
        {
            foreach (var button in gridButtons)
            {
                button.Enabled = false;
            }
        }

        // ����� ��� ������� ������ ������ �� ������� ����
        public void ClearGrid()
        {
            foreach (var button in gridButtons)
            {
                button.Text = string.Empty;
            }
        }

        // ����� ��� ���������� ������ ������ �� �����������
        public void UpdateButton(int row, int col, string text)
        {
            gridButtons[row, col].Text = text;
        }

        // ����� ��� �����������, ����� ����� �������� ����
        public bool IsPlayerStarting()
        {
            return playerStartsCheckbox.Checked;
        }

        // ����� ��� ��������� ������ ���� (������/�������)
        public bool IsEasyMode()
        {
            return easyMode.Checked;
        }
    }
}
