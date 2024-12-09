namespace TicTacToeApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button[,] gridButtons;
        private System.Windows.Forms.RadioButton easyMode;
        private System.Windows.Forms.RadioButton hardMode;
        private System.Windows.Forms.CheckBox playerStartsCheckbox;
        private System.Windows.Forms.Button restartButton;

        // Метод освобождения ресурсов
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.gridButtons = new System.Windows.Forms.Button[3, 3];
            this.easyMode = new System.Windows.Forms.RadioButton();
            this.hardMode = new System.Windows.Forms.RadioButton();
            this.playerStartsCheckbox = new System.Windows.Forms.CheckBox();
            this.restartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Создание кнопок для игрового поля
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    gridButtons[row, col] = new System.Windows.Forms.Button
                    {
                        Size = new System.Drawing.Size(100, 100),
                        Location = new System.Drawing.Point(100 * col, 100 * row + 25),
                        Font = new System.Drawing.Font("Arial", 24, System.Drawing.FontStyle.Bold),
                        Name = $"button{row}{col}" // Добавлено имя для кнопки
                    };
                    gridButtons[row, col].Click += new System.EventHandler(this.GridButton_Click);
                    this.Controls.Add(gridButtons[row, col]);
                }
            }

            // Настройки радио-кнопок
            this.easyMode.Text = "Легкий";
            this.easyMode.Location = new System.Drawing.Point(10, 320);
            this.easyMode.Checked = true;

            this.hardMode.Text = "Сложный";
            this.hardMode.Location = new System.Drawing.Point(10, 350);

            // Настройки чекбокса
            this.playerStartsCheckbox.Text = "X ходит первым";
            this.playerStartsCheckbox.Location = new System.Drawing.Point(10, 380);
            this.playerStartsCheckbox.Checked = true;

            // Настройки кнопки перезапуска
            this.restartButton.Text = "Новая игра";
            this.restartButton.Location = new System.Drawing.Point(150, 350);
            this.restartButton.Size = new System.Drawing.Size(100, 50);
            this.restartButton.Click += new System.EventHandler(this.RestartButton_Click);

            // Настройки формы
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Text = "Крестики-нолики";
            this.Controls.Add(this.easyMode);
            this.Controls.Add(this.hardMode);
            this.Controls.Add(this.playerStartsCheckbox);
            this.Controls.Add(this.restartButton);

            this.ResumeLayout(false);
        }
    }
}
