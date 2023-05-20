namespace PlatformGame
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод для изменения цвета кнопки exit при наведении на нее мыши
        /// </summary>
        private void exitBotton_MouseHover(object sender, EventArgs e)
        {
            exitBotton.Image = Properties.Resources.exit_orange;
        }

        /// <summary>
        /// Метод для закрывания игры при нажатии на кнопку exit
        /// </summary>
        private void exitBotton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Метод для 
        /// </summary>
        private void exitBotton_MouseLeave(object sender, EventArgs e)
        {
            exitBotton.Image = Properties.Resources.exit_green;
        }

        /// <summary>
        /// Метод для перехода к игре при нажатии на кнопку start
        /// </summary>
        private void startBotton_Click(object sender, EventArgs e)
        {
            Level1 level1 = new Level1();
            level1.ShowDialog();
        }

        /// <summary>
        /// Метод для изменения цвета кнопки exit при наведении на нее мыши
        /// </summary>
        private void startBotton_MouseHover(object sender, EventArgs e)
        {
            startBotton.Image = Properties.Resources.start_orange;
        }

        private void startBotton_MouseLeave(object sender, EventArgs e)
        {
            startBotton.Image = Properties.Resources.start_green;
        }

    }
}